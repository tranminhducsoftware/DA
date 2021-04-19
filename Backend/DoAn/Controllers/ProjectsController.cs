using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn.Models;
using DoAn.Modules.Projects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoAn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectContext;

        public ProjectsController(IProjectService projectContext)
        {
            _projectContext = projectContext;
        }


        /// <summary>
        /// Get tài khoản.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        /// <response code="200">Lấy dữ liệu thành công</response>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjects(int pageSize, int pageNumber)
        {
            var projectList = await _projectContext.Get();
            if (pageSize > 0 && pageNumber > 0)
            {
                projectList = projectList.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            }
            return Ok(projectList);
        }


        /// <summary>
        /// Tạo tài khoản
        /// </summary>
        /// <param name="account">tài khoản.</param>
        /// <returns>Kết quả.</returns>
        /// <response code="201">Tạo thành công</response>
        [HttpPost]
        public async Task<ActionResult<Project>> CreateProject(Project projectToCreate)
        {
            if (projectToCreate == null)
            {
                return BadRequest("Yêu cầu không hợp lệ");
            }

            try
            {
                if ((await _projectContext.Get()).FirstOrDefault(project => project.SortName == projectToCreate.SortName) != null)
                {
                    return BadRequest("Tên ngắn đã tồn tại");
                }

                projectToCreate = await _projectContext.Create(projectToCreate);
                return CreatedAtAction(nameof(GetProjects), new { id = projectToCreate.Id }, projectToCreate);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}
