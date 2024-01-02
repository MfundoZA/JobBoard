using JobBoard.Data;
using JobBoard.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Text.RegularExpressions;

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

        // Post: AuthController/Register
        [HttpPost]
        public ActionResult Register(IFormCollection collection)
        {
            var firstName = collection["firstName"];
            var lastName = collection["lastName"];
            var submittedEmail = collection["email"];
            var submittedPassword = collection["password"];
            var submittedConfirmPassword = collection["confirmPassword"];
            var phoneNumber = collection["phoneNumber"];
            var cityBased = collection["cityBased"];

            if (IsValidEmail(submittedEmail) == false)
            {
                return BadRequest("Email is not valid");
            }
            else if (IsValidPassword(submittedPassword) == false)
            {
                return BadRequest("Password must be at least 8 characters long and contain at least one number and one uppercase letter");
            }
            else if (submittedPassword != submittedConfirmPassword)
            {
                return BadRequest("Passwords do not match");
            }
            else if (_context.Users.Any(u => u.Email == submittedEmail))
            {
                return BadRequest("Email already exists. Please try logging in.");
            }
            else
            {
                // create new user
                var newUser = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = submittedEmail,
                    Password = submittedPassword,
                    PhoneNumber = phoneNumber,
                    Profile = new Profile(),
                    CityBased = cityBased
                };
                newUser.Profile.User = newUser;

                // add new user to database
                _context.Users.Add(newUser);
                _context.SaveChanges();

                // return new user
                return Ok(newUser);
            }
        }

        [HttpGet]
        public ActionResult Login(IFormCollection collection)
        {
            var email = collection["email"];
            var password = collection["password"];

            if (IsValidEmail(email) == false)
            {
                return BadRequest("Email is not valid");
            }
            else if (_context.Users.Any(u => u.Email == email && u.Password == password))
            {
                var currentUser = _context.Users.First(u => u.Email == email);
                
                return Ok(currentUser);
            }
            else
            {
                return BadRequest("Incorrect email address or password. Please try again.");
            }
        }

        // If the string cannot be converted to a MailAddress object, then the email is not valid
        [NonAction]
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

        [NonAction]
        public bool IsValidPassword(string submittedPassword)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            var isValid = hasNumber.IsMatch(submittedPassword) && hasUpperChar.IsMatch(submittedPassword) && hasMinimum8Chars.IsMatch(submittedPassword);

            return isValid;
        }

        // Todo: Implement hashing algorithm
    }
}
