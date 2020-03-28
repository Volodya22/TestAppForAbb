namespace TestAppForAbb.Core.Models
{
    /// <summary>
    /// Measure for Combustion Motor
    /// </summary>
    public class TorqueMeasure : AbstractEntity
    {
        /// <summary>
        /// Measure identifier
        /// </summary>
        public int MeasureId { get; set; }

        /// <summary>
        /// Motor identifier
        /// </summary>
        public int CombustionMotorId { get; set; }

        /// <summary>
        /// Actual revs (rpm)
        /// </summary>
        public double Torque { get; set; }

        /// <summary>
        /// Related measure
        /// </summary>
        public Measure Measure { get; set; }

        /// <summary>
        /// Related motor
        /// </summary>
        public virtual CombustionMotor CombustionMotor { get; set; }
    }
}
