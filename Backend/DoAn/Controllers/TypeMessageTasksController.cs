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
    public class TypeMessageTasksController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TypeMessageTasksController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/TypeMessageTasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypeMessageTask>>> GetTypeMessageTask()
        {
            return await _context.TypeMessageTask.ToListAsync();
        }

        // GET: api/TypeMessageTasks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TypeMessageTask>> GetTypeMessageTask(int id)
        {
            var typeMessageTask = await _context.TypeMessageTask.FindAsync(id);

            if (typeMessageTask == null)
            {
                return NotFound();
            }

            return typeMessageTask;
        }

        // PUT: api/TypeMessageTasks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypeMessageTask(int id, TypeMessageTask typeMessageTask)
        {
            if (id != typeMessageTask.Id)
            {
                return BadRequest();
            }

            _context.Entry(typeMessageTask).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeMessageTaskExists(id))
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

        // POST: api/TypeMessageTasks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TypeMessageTask>> PostTypeMessageTask(TypeMessageTask typeMessageTask)
        {
            _context.TypeMessageTask.Add(typeMessageTask);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTypeMessageTask", new { id = typeMessageTask.Id }, typeMessageTask);
        }

        // DELETE: api/TypeMessageTasks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTypeMessageTask(int id)
        {
            var typeMessageTask = await _context.TypeMessageTask.FindAsync(id);
            if (typeMessageTask == null)
            {
                return NotFound();
            }

            _context.TypeMessageTask.Remove(typeMessageTask);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TypeMessageTaskExists(int id)
        {
            return _context.TypeMessageTask.Any(e => e.Id == id);
        }
    }
}
