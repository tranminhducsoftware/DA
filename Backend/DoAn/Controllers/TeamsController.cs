using DoAn.Models;
using DoAn.Modules.Teams;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamService _teamContext;

        public TeamsController(ITeamService teamContext)
        {
            _teamContext = teamContext;
        }


        /// <summary>
        /// Get team.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        /// <response code="200">Lấy dữ liệu thành công</response>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Team>>> GetTeams(int pageSize, int pageNumber)
        {
            var teamList = await _teamContext.Get();
            if (pageSize > 0 && pageNumber > 0)
            {
                teamList = teamList.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            }

            return Ok(teamList);
        }

        /// <summary>
        /// Get team theo id.
        /// </summary>
        /// <param name="id">id team.</param>
        /// <returns>tài khoản.</returns>
        /// <response code="200">Lấy dữ liệu thành công</response>
        [HttpGet("{id}")]
        public async Task<ActionResult<Team>> getTeam(int id)
        {
            var team = await _teamContext.Get(id);
            if (team == null)
            {
                return NotFound();
            }

            return Ok(team);
        }

        /// <summary>
        /// Tạo team 
        /// </summary>
        /// <param name="teamToCreate">team</param>
        /// <returns>Kết quả.</returns>
        /// <response code="201">Tạo thành công</response>
        [HttpPost]
        public async Task<ActionResult<Team>> CreateTeam(Team teamToCreate)
        {
            if (teamToCreate == null)
            {
                return BadRequest("Yêu cầu không hợp lệ");
            }

            try
            {
                if ((await _teamContext.Get()).FirstOrDefault(team => team.Name == teamToCreate.Name) != null)
                {
                    return BadRequest("Tên nhóm đã tồn tại");
                }

                teamToCreate = await _teamContext.Create(teamToCreate);
                return CreatedAtAction(nameof(GetTeams), new { id = teamToCreate.Id }, teamToCreate);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        /// <summary>
        /// Update team
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="team">team.</param>
        /// <returns>Kết quả.</returns>
        /// <response code="204">Cập nhật thành công</response>
        [HttpPut]
        public async Task<IActionResult> UpdateTeam(int id, Team team)
        {
            if (id != team.Id)
            {
                return BadRequest("Yêu cầu không hợp lệ");
            }

            try
            {
                if (await TeamExsits(id))
                {
                    return NotFound("Nhóm không tồn tại");
                }
                await _teamContext.Update(team);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        /// <summary>
        /// Xóa team
        /// </summary>
        /// <param name="id">id.</param>
        /// <returns>Kết quả.</returns>
        /// <response code="204">Xóa thành công</response>
        [HttpDelete]
        public async Task<ActionResult<Team>> DeleteTeam(int id)
        {
            try
            {
                if(await TeamExsits(id))
                {
                    return NotFound("Nhóm không tồn tại");
                }
                await _teamContext.Remove(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        private async Task<bool> TeamExsits(int id)
        {
            return await _teamContext.Get(id) !=null;
        }

    }
}
