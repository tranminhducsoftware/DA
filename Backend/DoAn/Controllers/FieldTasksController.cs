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
    public class FieldTasksController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public FieldTasksController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/FieldTasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FieldTask>>> GetFieldTasks()
        {
            return await _context.FieldTasks.ToListAsync();
        }

        // GET: api/FieldTasks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FieldTask>> GetFieldTask(int id)
        {
            var fieldTask = await _context.FieldTasks.FindAsync(id);

            if (fieldTask == null)
            {
                return NotFound();
            }

            return fieldTask;
        }

        // PUT: api/FieldTasks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFieldTask(int id, FieldTask fieldTask)
        {
            if (id != fieldTask.Id)
            {
                return BadRequest();
            }

            _context.Entry(fieldTask).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FieldTaskExists(id))
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

        // POST: api/FieldTasks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FieldTask>> PostFieldTask(FieldTask fieldTask)
        {
            _context.FieldTasks.Add(fieldTask);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFieldTask", new { id = fieldTask.Id }, fieldTask);
        }

        // DELETE: api/FieldTasks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFieldTask(int id)
        {
            var fieldTask = await _context.FieldTasks.FindAsync(id);
            if (fieldTask == null)
            {
                return NotFound();
            }

            _context.FieldTasks.Remove(fieldTask);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FieldTaskExists(int id)
        {
            return _context.FieldTasks.Any(e => e.Id == id);
        }
    }
}
