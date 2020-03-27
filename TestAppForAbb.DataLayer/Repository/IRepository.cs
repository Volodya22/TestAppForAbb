using Microsoft.EntityFrameworkCore;
using TestAppForAbb.Core.Models;

namespace TestAppForAbb.DataLayer.Repository
{
    public interface IRepository
    {
        DbSet<Motor> Motors { get; set; }

        DbSet<ElectricMotor> ElectricMotors { get; set; }

        DbSet<CombustionMotor> CombustionMotors { get; set; }

        DbSet<HydraulicMotor> HydraulicMotors { get; set; }

        DbSet<Measure> Measures { get; set; }

        DbSet<CurrentMeasure> CurrentMeasures { get; set; }

        DbSet<PressureMeasure> PressureMeasures { get; set; }

        DbSet<TorqueMeasure> TorqueMeasures { get; set; }

        int SaveChanges();
    }
}
