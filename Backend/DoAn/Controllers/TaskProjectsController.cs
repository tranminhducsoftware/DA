using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DoAn.Models;
using DoAn.Models.Context;

namespace DoAn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskProjectsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TaskProjectsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/TaskProjects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskProject>>> GetTaskProjects()
        {
            return await _context.TaskProjects.ToListAsync();
        }

        // GET: api/TaskProjects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskProject>> GetTaskProject(int id)
        {
            var taskProject = await _context.TaskProjects.FindAsync(id);

            if (taskProject == null)
            {
                return NotFound();
            }

            return taskProject;
        }

        // PUT: api/TaskProjects/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaskProject(int id, TaskProject taskProject)
        {
            if (id != taskProject.Id)
            {
                return BadRequest();
            }

            _context.Entry(taskProject).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskProjectExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TaskProjects
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TaskProject>> PostTaskProject(TaskProject taskProject)
        {
            _context.TaskProjects.Add(taskProject);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTaskProject", new { id = taskProject.Id }, taskProject);
        }

        // DELETE: api/TaskProjects/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaskProject(int id)
        {
            var taskProject = await _context.TaskProjects.FindAsync(id);
            if (taskProject == null)
            {
                return NotFound();
            }

            _context.TaskProjects.Remove(taskProject);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TaskProjectExists(int id)
        {
            return _context.TaskProjects.Any(e => e.Id == id);
        }
    }
}
