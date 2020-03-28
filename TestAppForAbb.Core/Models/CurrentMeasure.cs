namespace TestAppForAbb.Core.Models
{
    /// <summary>
    /// Measure for Electric Motor
    /// </summary>
    public class CurrentMeasure : AbstractEntity
    {
        /// <summary>
        /// Identifier of related measure
        /// </summary>
        public int MeasureId { get; set; }

        /// <summary>
        /// Identifier of related motor
        /// </summary>
        public int ElectricMotorId { get; set; }

        /// <summary>
        /// Actual current (A)
        /// </summary>
        public double Current { get; set; }

        /// <summary>
        /// Related Measure
        /// </summary>
        public Measure Measure { get; set; }

        /// <summary>
        /// Related Electric Motor
        /// </summary>
        public virtual ElectricMotor ElectricMotor { get; set; }
    }
}
