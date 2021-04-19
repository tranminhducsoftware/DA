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
    public class TaskMessagesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TaskMessagesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/TaskMessages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskMessage>>> GetTaskMessages()
        {
            return await _context.TaskMessages.ToListAsync();
        }

        // GET: api/TaskMessages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskMessage>> GetTaskMessage(int id)
        {
            var taskMessage = await _context.TaskMessages.FindAsync(id);

            if (taskMessage == null)
            {
                return NotFound();
            }

            return taskMessage;
        }

        // PUT: api/TaskMessages/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaskMessage(int id, TaskMessage taskMessage)
        {
            if (id != taskMessage.Id)
            {
                return BadRequest();
            }

            _context.Entry(taskMessage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskMessageExists(id))
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

        // POST: api/TaskMessages
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TaskMessage>> PostTaskMessage(TaskMessage taskMessage)
        {
            _context.TaskMessages.Add(taskMessage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTaskMessage", new { id = taskMessage.Id }, taskMessage);
        }

        // DELETE: api/TaskMessages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaskMessage(int id)
        {
            var taskMessage = await _context.TaskMessages.FindAsync(id);
            if (taskMessage == null)
            {
                return NotFound();
            }

            _context.TaskMessages.Remove(taskMessage);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TaskMessageExists(int id)
        {
            return _context.TaskMessages.Any(e => e.Id == id);
        }
    }
}
