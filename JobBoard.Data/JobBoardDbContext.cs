using JobBoard.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Data
{
    public class JobBoardDbContext : DbContext
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<Profile>? Profiles { get; set; }
        public DbSet<Milestone>? Milestones { get; set; }
        public DbSet<Project>? Projects { get; set; }
        public DbSet<Skill>? Skills { get; set; }
        public DbSet<Certification>? Certifications { get; set; }

        public DbSet<Company>? Companies { get; set; }
        public DbSet<Opening>? Openings { get; set; }

        public DbSet<ProfileSkill>? ProfileSkills { get; set; }
        public DbSet<ProfileCertification>? ProfileCertifications { get; set; }
        public DbSet<ProfileOpening>? ProfileOpenings { get; set; }

        public JobBoardDbContext()
        {

        }

        public JobBoardDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=JORDAN;Initial Catalog=JobBoardDb;Integrated Security=True");
        }
    }
}
