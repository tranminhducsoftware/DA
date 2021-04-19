using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn.Models;
using DoAn.Modules.Accounts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoAn.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [Authorize]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accountContext;

        public AccountsController(IAccountService accountContext)
        {
            _accountContext = accountContext;
        }

        /// <summary>
        /// Get tài khoản.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        /// <response code="200">Lấy dữ liệu thành công</response>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> GetAccounts(int pageSize, int pageNumber)
        {
            var accountList = await _accountContext.Get();
            accountList.ForEach(account => account.Password = null);

            if (pageSize > 0 && pageNumber > 0)
            {
                accountList = accountList.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            }
            return Ok(accountList);
        }

        /// <summary>
        /// Get tài khoản theo id.
        /// </summary>
        /// <param name="id">id tài khoản.</param>
        /// <returns>tài khoản.</returns>
        /// <response code="200">Lấy dữ liệu thành công</response>
        [HttpGet("{id}")]
        public async Task<ActionResult<Account>> getAccount(int id)
        {
            var account = await _accountContext.Get(id);

            if (account == null)
            {
                return NotFound();
            }

            account.Password = null;
            return Ok(account);
        }

        /// <summary>
        /// Tạo tài khoản
        /// </summary>
        /// <param name="account">tài khoản.</param>
        /// <returns>Kết quả.</returns>
        /// <response code="201">Tạo thành công</response>
        [HttpPost]
        public async Task<ActionResult<Account>> CreateAccount(Account accountToCreate)
        {
            if (accountToCreate == null)
            {
                return BadRequest("Yêu cầu không hợp lệ");
            }

            try
            {
                if ((await _accountContext.Get()).FirstOrDefault(account => account.Email == accountToCreate.Email) != null)
                {
                    return BadRequest("Email đã tồn tại");
                }

                accountToCreate.Password = BCrypt.Net.BCrypt.HashPassword(accountToCreate.Password);
                accountToCreate = await _accountContext.Create(accountToCreate);
                accountToCreate.Password = null;
                return CreatedAtAction(nameof(GetAccounts), new { id = accountToCreate.Id }, accountToCreate);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        /// <summary>
        /// Update tài khoản
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="account">tài khoản.</param>
        /// <returns>Kết quả.</returns>
        /// <response code="204">Cập nhật thành công</response>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAccount(int id, Account account)
        {
            if (id != account.Id)
            {
                return BadRequest("Yêu cầu không hợp lệ");
            }

            try
            {
                if (!await AccountExists(id))
                {
                    return NotFound("Tài khoản không tồn tại");
                }

                var accountInDb = await _accountContext.Get(id).ConfigureAwait(false);
                var oldPassword = accountInDb.Password;
                accountInDb.Password = string.IsNullOrEmpty(account.Password) ? oldPassword : BCrypt.Net.BCrypt.HashPassword(account.Password);
                accountInDb.Email = account.Email;
                await _accountContext.Update(account);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        /// <summary>
        /// Xóa tài khoản
        /// </summary>
        /// <param name="id">id.</param>
        /// <returns>Kết quả.</returns>
        /// <response code="204">Xóa thành công</response>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Account>> DeleteAccount(int id)
        {
            try
            {
                if (!await AccountExists(id))
                {
                    return NotFound("Tài khoản không tồn tại");
                }
                await _accountContext.Remove(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }

        }



        private async Task<bool> AccountExists(int id)
        {
            return await _accountContext.Get(id) != null;
        }

    }
}
