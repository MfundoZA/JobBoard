using JobBoard.Data.Models;
using JobBoard.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JobBoard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificationsController : ControllerBase
    {
        private readonly JobBoardDbContext _context;

        public CertificationsController(JobBoardDbContext context)
        {
                _context = context;
        }

        // GET: api/Certifications
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Certification>>> GetCertificates()
        {
            if (_context.Certifications == null)
            {
                return NotFound();
            }

            return await _context.Certifications.ToListAsync();
        }

        // GET: api/Certifications/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Certification>> GetCertification(int id)
        {
            if (_context.Certifications == null)
            {
                return NotFound();
            }
            var certification = await _context.Certifications.FindAsync(id);

            if (certification == null)
            {
                return NotFound();
            }

            return certification;
        }

        // PUT: api/Certifications/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCertification(int id, Certification certification)
        {
            if (id != certification.Id)
            {
                return BadRequest();
            }

            _context.Entry(certification).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CertificationExists(id))
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

        // POST: api/Certifications
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Certification>> PostCertifications(Certification certification)
        {
            if (_context.Certifications == null)
            {
                return Problem("Entity set 'JobBoardDbContext.Certification' is null.");
            }
            _context.Certifications.Add(certification);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCertification", new { id = certification.Id }, certification);
        }

        // DELETE: api/Certifications/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCertification(int id)
        {
            if (_context.Certifications == null)
            {
                return NotFound();
            }
            var certification = await _context.Certifications.FindAsync(id);
            if (certification == null)
            {
                return NotFound();
            }

            _context.Certifications.Remove(certification);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CertificationExists(int id)
        {
            return (_context.Certifications?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
