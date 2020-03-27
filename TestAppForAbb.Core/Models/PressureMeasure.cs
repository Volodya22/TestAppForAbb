namespace TestAppForAbb.Core.Models
{
    public class PressureMeasure : AbstractEntity
    {
        public int MeasureId { get; set; }

        public int HydraulicMotorId { get; set; }

        public double Pressure { get; set; }

        public Measure Measure { get; set; }

        public virtual HydraulicMotor HydraulicMotor { get; set; }
    }
}
