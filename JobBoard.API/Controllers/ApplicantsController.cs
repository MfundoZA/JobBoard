using JobBoard.Data.Models;
using JobBoard.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JobBoard.API.Controllers
{
    [Route("api/Applicants")]
    [ApiController]
    public class ApplicantsController : ControllerBase
    {
        private readonly JobBoardDbContext _context;
        public IHttpContextAccessor? HttpContextAccessor { get; set; }

        public ApplicantsController(JobBoardDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            HttpContextAccessor = httpContextAccessor;
        }

        // GET: api/Applicants
        // Will return the current company's applicants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProfileOpening>>> GetApplicants()
        {
            var currentCompanyId = HttpContextAccessor?.HttpContext?.Session.GetInt32("companyId");
            var companyApplicants = _context.ProfileOpenings?.Where(e => e.Opening.Company.Id == currentCompanyId);

            if (companyApplicants == null)
            {
                return NotFound();
            }

            return await companyApplicants.ToListAsync();
        }

        // GET: api/Openings/5/Applicants/5
        [HttpGet("{openingId}/Applicants/{applicantId}")]
        public async Task<ActionResult<Profile>> GetApplicant(int openingId, int applicantId)
        {
            if (_context.ProfileOpenings == null)
            {
                return NotFound();
            }

            var opening = await _context.ProfileOpenings.Where(e => e.OpeningId == openingId).FirstOrDefaultAsync();

            if (opening != null)
            {
                var applicant = opening.Opening?.Applicants?.Find(e => e.Id == applicantId);

                if (applicant == null)
                {
                    return NotFound();
                }
                else
                {
                    return applicant;
                }
            }
            else
            {
                return NotFound();
            }
        }
    }
}
