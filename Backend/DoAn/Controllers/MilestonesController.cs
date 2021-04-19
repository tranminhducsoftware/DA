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
    public class MilestonesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public MilestonesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Milestones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Milestone>>> GetMilestone()
        {
            return await _context.Milestone.ToListAsync();
        }

        // GET: api/Milestones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Milestone>> GetMilestone(int id)
        {
            var milestone = await _context.Milestone.FindAsync(id);

            if (milestone == null)
            {
                return NotFound();
            }

            return milestone;
        }

        // PUT: api/Milestones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMilestone(int id, Milestone milestone)
        {
            if (id != milestone.Id)
            {
                return BadRequest();
            }

            _context.Entry(milestone).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MilestoneExists(id))
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

        // POST: api/Milestones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Milestone>> PostMilestone(Milestone milestone)
        {
            _context.Milestone.Add(milestone);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMilestone", new { id = milestone.Id }, milestone);
        }

        // DELETE: api/Milestones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMilestone(int id)
        {
            var milestone = await _context.Milestone.FindAsync(id);
            if (milestone == null)
            {
                return NotFound();
            }

            _context.Milestone.Remove(milestone);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MilestoneExists(int id)
        {
            return _context.Milestone.Any(e => e.Id == id);
        }
    }
}
