namespace TestAppForAbb.Core.Models
{
    public class CurrentMeasure : AbstractEntity
    {
        public int MeasureId { get; set; }

        public int ElectricMotorId { get; set; }

        public double Current { get; set; }

        public Measure Measure { get; set; }

        public virtual ElectricMotor ElectricMotor { get; set; }
    }
}
