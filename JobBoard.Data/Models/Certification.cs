using JobBoard.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Data.Models
{
    public class Certification
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Issuer { get; set; } = null!;
        public DateTime DateIssued { get; set; }
        public DateTime? DateExpires { get; set; }
        public List<Profile>? Profiles { get; set; }

        public Certification()
        {
            
        }

        public Certification(int id, string title, string issuer, DateTime dateIssued, DateTime? dateExpires,
            List<Profile>? profiles)
        {
            Id = id;
            Title = title;
            Issuer = issuer;
            DateIssued = dateIssued;
            DateExpires = dateExpires;
            Profiles = profiles;
        }
    }
}
