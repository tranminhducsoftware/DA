using DoAn.Data;
using DoAn.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IconsController : ControllerBase
    {
        private readonly IRepository<Icon> _iconContext;
        public IconsController(IRepository<Icon> iconContext)
        {
            _iconContext = iconContext;
        }

        /// <summary>
        /// Get tài khoản.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        /// <response code="200">Lấy dữ liệu thành công</response>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Icon>>> GetIcons(int pageSize, int pageNumber)
        {
            var iconList = await _iconContext.Get();
            if(pageSize>0 && pageNumber >0)
            {
                iconList = iconList.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            }

            return Ok(iconList);
        }

        /// <summary>
        /// Get icon theo id.
        /// </summary>
        /// <param name="id">id icon.</param>
        /// <returns>tài khoản.</returns>
        /// <response code="200">Lấy dữ liệu thành công</response>
        [HttpGet("{id}")]
        public async Task<ActionResult<Icon>> GetIcon(int id)
        {
            var icon = await _iconContext.Get(id);
            if(icon == null)
            {
                return NotFound();
            }
            return Ok(icon);
        }

        /// <summary>
        /// Tạo icon
        /// </summary>
        /// <param name="icon">icon.</param>
        /// <returns>Kết quả.</returns>
        /// <response code="201">Tạo thành công</response>
        [HttpPost]
        public async Task<ActionResult<Icon>> CreateIcon( Icon iconToCreate)
        {
            if(iconToCreate == null)
            {
                return BadRequest("Yêu cầu không hợp lệ");
            }

            try
            {
                if((await _iconContext.Get() ).FirstOrDefault(icon =>icon.Name == iconToCreate.Name) != null)
                {
                    return BadRequest("Tên icon đã tồn tại");
                }
                iconToCreate = await _iconContext.Create(iconToCreate);

                return Ok(iconToCreate);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }


        /// <summary>
        /// Update icon
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="team">icon.</param>
        /// <returns>Kết quả.</returns>
        /// <response code="204">Cập nhật thành công</response>
        [HttpPut]
        public async Task<IActionResult> UpdateTeam(int id, Icon icon)
        {
            if (id != icon.Id)
            {
                return BadRequest("Yêu cầu không hợp lệ");
            }

            try
            {
                if (await TeamExsits(id))
                {
                    return NotFound("Icon không tồn tại");
                }
                await _iconContext.Update(icon);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        /// <summary>
        /// Xóa icon
        /// </summary>
        /// <param name="id">id.</param>
        /// <returns>Kết quả.</returns>
        /// <response code="204">Xóa thành công</response>
        [HttpDelete]
        public async Task<ActionResult<Icon>> DeleteTeam(int id)
        {
            try
            {
                if (await TeamExsits(id))
                {
                    return NotFound("Icon không tồn tại");
                }
                await _iconContext.Remove(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        private async Task<bool> TeamExsits(int id)
        {
            return await _iconContext.Get(id) != null;
        }


    }
}
