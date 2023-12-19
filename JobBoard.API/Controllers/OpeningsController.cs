using JobBoard.Data.Models;
using JobBoard.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JobBoard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpeningsController : ControllerBase
    {
        private readonly JobBoardDbContext _context;

        public OpeningsController(JobBoardDbContext context)
        {
                _context = context;
        }

        // GET: api/Openings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Opening>>> GetOpenings()
        {
            if (_context.Openings == null)
            {
                return NotFound();
            }

            return await _context.Openings.ToListAsync();
        }

        // GET: api/Openings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Opening>> GetOpening(int id)
        {
            if (_context.Openings == null)
            {
                return NotFound();
            }
            var opening = await _context.Openings.FindAsync(id);

            if (opening == null)
            {
                return NotFound();
            }

            return opening;
        }

        // PUT: api/Openings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, Opening opening)
        {
            if (id != opening.Id)
            {
                return BadRequest();
            }

            _context.Entry(opening).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OpeningExists(id))
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

        // POST: api/Openings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Opening>> PostOpening(Opening opening)
        {
            if (_context.Openings == null)
            {
                return Problem("Entity set 'JobBoardDbContext.Opening' is null.");
            }
            _context.Openings.Add(opening);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOpening", new { id = opening.Id }, opening);
        }

        // DELETE: api/Openings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOpening(int id)
        {
            if (_context.Openings == null)
            {
                return NotFound();
            }
            var opening = await _context.Openings.FindAsync(id);
            if (opening == null)
            {
                return NotFound();
            }

            _context.Openings.Remove(opening);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OpeningExists(int id)
        {
            return (_context.Openings?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
