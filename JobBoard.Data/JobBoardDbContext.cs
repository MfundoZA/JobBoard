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
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Profile> Profiles { get; set; } = null!;

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
