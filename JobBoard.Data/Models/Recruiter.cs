using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Data.Models
{
    public class Recruiter
    {
        public int Id { get; private set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public Company Company { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public Profile Profile { get; set; } = null!;
        public string? CityBased { get; set; }
    }
}
