using JobBoard.Data.Models;
using JobBoard.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JobBoard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly JobBoardDbContext _context;
        private IHttpContextAccessor? HttpContextAccessor { get; set; }

        public AuthController(JobBoardDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            HttpContextAccessor = httpContextAccessor;
        }
    }
}
