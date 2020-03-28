using Microsoft.EntityFrameworkCore;
using TestAppForAbb.Core.Models;

namespace TestAppForAbb.DataLayer.Repository
{
    /// <inheritdoc cref="IRepository" />
    public class MotorDbContext : DbContext, IRepository
    {
        public MotorDbContext(DbContextOptions<MotorDbContext> options) : base(options)
        {

        }

        public DbSet<Motor> Motors { get; set; }

        public DbSet<ElectricMotor> ElectricMotors { get; set; }

        public DbSet<CombustionMotor> CombustionMotors { get; set; }

        public DbSet<HydraulicMotor> HydraulicMotors { get; set; }

        public DbSet<Measure> Measures { get; set; }

        public DbSet<CurrentMeasure> CurrentMeasures { get; set; }

        public DbSet<PressureMeasure> PressureMeasures { get; set; }

        public DbSet<TorqueMeasure> TorqueMeasures { get; set; }
    }
}
