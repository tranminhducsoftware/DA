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
    public class FieldLevelsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public FieldLevelsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/FieldLevels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FieldLevel>>> GetFieldLevels()
        {
            return await _context.FieldLevels.ToListAsync();
        }

        // GET: api/FieldLevels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FieldLevel>> GetFieldLevel(int id)
        {
            var fieldLevel = await _context.FieldLevels.FindAsync(id);

            if (fieldLevel == null)
            {
                return NotFound();
            }

            return fieldLevel;
        }

        // PUT: api/FieldLevels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFieldLevel(int id, FieldLevel fieldLevel)
        {
            if (id != fieldLevel.Id)
            {
                return BadRequest();
            }

            _context.Entry(fieldLevel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FieldLevelExists(id))
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

        // POST: api/FieldLevels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FieldLevel>> PostFieldLevel(FieldLevel fieldLevel)
        {
            _context.FieldLevels.Add(fieldLevel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFieldLevel", new { id = fieldLevel.Id }, fieldLevel);
        }

        // DELETE: api/FieldLevels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFieldLevel(int id)
        {
            var fieldLevel = await _context.FieldLevels.FindAsync(id);
            if (fieldLevel == null)
            {
                return NotFound();
            }

            _context.FieldLevels.Remove(fieldLevel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FieldLevelExists(int id)
        {
            return _context.FieldLevels.Any(e => e.Id == id);
        }
    }
}
