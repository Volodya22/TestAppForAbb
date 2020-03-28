using Microsoft.EntityFrameworkCore;
using TestAppForAbb.Core.Models;

namespace TestAppForAbb.DataLayer.Repository
{
    /// <summary>
    /// Data Repository
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Set of Motors
        /// </summary>
        DbSet<Motor> Motors { get; set; }

        /// <summary>
        /// Set of Electric Motors
        /// </summary>
        DbSet<ElectricMotor> ElectricMotors { get; set; }

        /// <summary>
        /// Set of Combustion Motors
        /// </summary>
        DbSet<CombustionMotor> CombustionMotors { get; set; }

        /// <summary>
        /// Set of Hydraulic Motors
        /// </summary>
        DbSet<HydraulicMotor> HydraulicMotors { get; set; }

        /// <summary>
        /// Set of Measures
        /// </summary>
        DbSet<Measure> Measures { get; set; }

        /// <summary>
        /// Set of Current Measures
        /// </summary>
        DbSet<CurrentMeasure> CurrentMeasures { get; set; }

        /// <summary>
        /// Set of Pressure Measures
        /// </summary>
        DbSet<PressureMeasure> PressureMeasures { get; set; }

        /// <summary>
        /// Set of Torque Measures
        /// </summary>
        DbSet<TorqueMeasure> TorqueMeasures { get; set; }

        /// <summary>
        /// Save changes to Repository
        /// </summary>
        /// <returns>Result</returns>
        int SaveChanges();
    }
}
