using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningAsp.Models
{
    public class LearnDbContext : DbContext
    {
        public LearnDbContext(DbContextOptions<LearnDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }

    }
}
