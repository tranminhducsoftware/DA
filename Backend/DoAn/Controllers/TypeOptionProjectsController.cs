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
    public class TypeOptionProjectsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TypeOptionProjectsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/TypeOptionProjects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypeOptionProject>>> GetTypeOptionProjects()
        {
            return await _context.TypeOptionProjects.ToListAsync();
        }

        // GET: api/TypeOptionProjects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TypeOptionProject>> GetTypeOptionProject(int id)
        {
            var typeOptionProject = await _context.TypeOptionProjects.FindAsync(id);

            if (typeOptionProject == null)
            {
                return NotFound();
            }

            return typeOptionProject;
        }

        // PUT: api/TypeOptionProjects/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypeOptionProject(int id, TypeOptionProject typeOptionProject)
        {
            if (id != typeOptionProject.Id)
            {
                return BadRequest();
            }

            _context.Entry(typeOptionProject).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeOptionProjectExists(id))
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

        // POST: api/TypeOptionProjects
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TypeOptionProject>> PostTypeOptionProject(TypeOptionProject typeOptionProject)
        {
            _context.TypeOptionProjects.Add(typeOptionProject);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTypeOptionProject", new { id = typeOptionProject.Id }, typeOptionProject);
        }

        // DELETE: api/TypeOptionProjects/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTypeOptionProject(int id)
        {
            var typeOptionProject = await _context.TypeOptionProjects.FindAsync(id);
            if (typeOptionProject == null)
            {
                return NotFound();
            }

            _context.TypeOptionProjects.Remove(typeOptionProject);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TypeOptionProjectExists(int id)
        {
            return _context.TypeOptionProjects.Any(e => e.Id == id);
        }
    }
}
