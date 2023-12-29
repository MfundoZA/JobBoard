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
        // Entry tables
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Profile> Profiles { get; set; } = null!;
        public DbSet<Milestone> Milestones { get; set; } = null!;
        public DbSet<Project> Projects { get; set; } = null!;
        public DbSet<Skill> Skills { get; set; } = null!;
        public DbSet<Certification> Certifications { get; set; } = null!;

        public DbSet<Company> Companies { get; set; } = null!;
        public DbSet<Opening> Openings { get; set; } = null!;

        // Lookup tables
        public DbSet<ProfileSkill> ProfileSkills { get; set; } = null!;
        public DbSet<ProfileCertification> ProfileCertifications { get; set; } = null!;
        public DbSet<ProfileOpening> ProfileOpenings { get; set; } = null!;

        public DbSet<Recruiter> Recruiters { get; set; } = null!;

        public JobBoardDbContext() { }

        public JobBoardDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=JobBoardDb;Integrated Security=True");
        }
    }
}
