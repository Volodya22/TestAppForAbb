namespace TestAppForAbb.Core.Models
{
    /// <summary>
    /// Measure for Hydraulic Motor
    /// </summary>
    public class PressureMeasure : AbstractEntity
    {
        /// <summary>
        /// Measure identifier
        /// </summary>
        public int MeasureId { get; set; }

        /// <summary>
        /// Motor identifier
        /// </summary>
        public int HydraulicMotorId { get; set; }

        /// <summary>
        /// Actual pressure (bar)
        /// </summary>
        public double Pressure { get; set; }

        /// <summary>
        /// Related Measure
        /// </summary>
        public Measure Measure { get; set; }

        /// <summary>
        /// Related Motor
        /// </summary>
        public virtual HydraulicMotor HydraulicMotor { get; set; }
    }
}
