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
    public class ReportProjectsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ReportProjectsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/ReportProjects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReportProject>>> GetReportProjects()
        {
            return await _context.ReportProjects.ToListAsync();
        }

        // GET: api/ReportProjects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReportProject>> GetReportProject(int id)
        {
            var reportProject = await _context.ReportProjects.FindAsync(id);

            if (reportProject == null)
            {
                return NotFound();
            }

            return reportProject;
        }

        // PUT: api/ReportProjects/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReportProject(int id, ReportProject reportProject)
        {
            if (id != reportProject.Id)
            {
                return BadRequest();
            }

            _context.Entry(reportProject).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReportProjectExists(id))
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

        // POST: api/ReportProjects
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ReportProject>> PostReportProject(ReportProject reportProject)
        {
            _context.ReportProjects.Add(reportProject);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReportProject", new { id = reportProject.Id }, reportProject);
        }

        // DELETE: api/ReportProjects/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReportProject(int id)
        {
            var reportProject = await _context.ReportProjects.FindAsync(id);
            if (reportProject == null)
            {
                return NotFound();
            }

            _context.ReportProjects.Remove(reportProject);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReportProjectExists(int id)
        {
            return _context.ReportProjects.Any(e => e.Id == id);
        }
    }
}
