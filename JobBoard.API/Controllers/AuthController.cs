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

        // If the string cannot be converted to a MailAddress object, then the email is not valid
        public bool IsValidEmail(string submittedEmail)
        {
            try
            {
                var email = new MailAddress(submittedEmail);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool IsValidPassword(string submittedPassword)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            var isValid = hasNumber.IsMatch(submittedPassword) && hasUpperChar.IsMatch(submittedPassword) && hasMinimum8Chars.IsMatch(submittedPassword);
            
            return isValid;
        }
    }
}
