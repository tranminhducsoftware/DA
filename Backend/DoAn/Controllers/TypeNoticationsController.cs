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
    public class TypeNoticationsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TypeNoticationsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/TypeNotications
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypeNotication>>> GetTypeNotications()
        {
            return await _context.TypeNotications.ToListAsync();
        }

        // GET: api/TypeNotications/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TypeNotication>> GetTypeNotication(int id)
        {
            var typeNotication = await _context.TypeNotications.FindAsync(id);

            if (typeNotication == null)
            {
                return NotFound();
            }

            return typeNotication;
        }

        // PUT: api/TypeNotications/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypeNotication(int id, TypeNotication typeNotication)
        {
            if (id != typeNotication.Id)
            {
                return BadRequest();
            }

            _context.Entry(typeNotication).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeNoticationExists(id))
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

        // POST: api/TypeNotications
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TypeNotication>> PostTypeNotication(TypeNotication typeNotication)
        {
            _context.TypeNotications.Add(typeNotication);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTypeNotication", new { id = typeNotication.Id }, typeNotication);
        }

        // DELETE: api/TypeNotications/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTypeNotication(int id)
        {
            var typeNotication = await _context.TypeNotications.FindAsync(id);
            if (typeNotication == null)
            {
                return NotFound();
            }

            _context.TypeNotications.Remove(typeNotication);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TypeNoticationExists(int id)
        {
            return _context.TypeNotications.Any(e => e.Id == id);
        }
    }
}
