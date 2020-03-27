namespace TestAppForAbb.Core.Models
{
    public class TorqueMeasure : AbstractEntity
    {
        public int MeasureId { get; set; }

        public int CombustionMotorId { get; set; }

        public double Torque { get; set; }

        public Measure Measure { get; set; }

        public virtual CombustionMotor CombustionMotor { get; set; }
    }
}
