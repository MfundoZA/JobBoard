using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Data.Models
{
    public class Opening
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public Company Company { get; set; } = null!;
        public DateTime DatePosted { get; set; }
        public DateTime ClosingDate { get; set; }
        public JobType JobType { get; set; }
        public string Description { get; set; } = null!;
        public string? Responsibilities { get; set; }
        public string? Requirements { get; set; }
        public string? DesiredExperience { get; set; }
        public List<Profile>? Applicants { get; set; }

        public Opening()
        {
            
        }

        public Opening(int id, string title, Company company, DateTime datePosted,
            DateTime closingDate, JobType jobType, string description, string? responsibilities,
            string? requirements, string? desiredExperience, List<Profile>? applicants)
        {
            Id = id;
            Title = title;
            Company = company;
            DatePosted = datePosted;
            ClosingDate = closingDate;
            JobType = jobType;
            Description = description;
            Responsibilities = responsibilities;
            Requirements = requirements;
            DesiredExperience = desiredExperience;
            Applicants = applicants;
        }
    }
}
