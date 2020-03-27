using Microsoft.EntityFrameworkCore;
using TestAppForAbb.Core.Models;

namespace TestAppForAbb.DataLayer.Repository
{
    public class MotorDbContext : DbContext, IRepository
    {
        public MotorDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Motor> Motors { get; set; }

        public DbSet<Measure> Measures { get; set; }
    }
}
