using JobBoard.API.Models;
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
        DbSet<User> Users { get; set; } = null!;
        DbSet<Profile> Resumes { get; set; } = null!;

        public JobBoardDbContext(DbContextOptions options) : base(options) { }
    }
}
