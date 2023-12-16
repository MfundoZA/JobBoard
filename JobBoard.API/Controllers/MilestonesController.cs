using JobBoard.Data.Models;
using JobBoard.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JobBoard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly JobBoardDbContext _context;

        public ProjectsController(JobBoardDbContext context)
        {
                _context = context;
        }

        // GET: api/Milestones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Milestone>>> GetMilestones()
        {
            if (_context.Milestones == null)
            {
                return NotFound();
            }

            return await _context.Milestones.ToListAsync();
        }

        // GET: api/Milestones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Milestone>> GetMilestone(int id)
        {
            if (_context.Milestones == null)
            {
                return NotFound();
            }
            var milestone = await _context.Milestones.FindAsync(id);

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
            if (_context.Milestones == null)
            {
                return Problem("Entity set 'JobBoardDbContext.Milestone' is null.");
            }
            _context.Milestones.Add(milestone);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMilestone", new { id = milestone.Id }, milestone);
        }

        // DELETE: api/Milestones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMilestone(int id)
        {
            if (_context.Milestones == null)
            {
                return NotFound();
            }
            var milestone = await _context.Milestones.FindAsync(id);
            if (milestone == null)
            {
                return NotFound();
            }

            _context.Milestones.Remove(milestone);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MilestoneExists(int id)
        {
            return (_context.Milestones?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
