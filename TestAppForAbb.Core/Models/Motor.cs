using TestAppForAbb.Core.Enum;

namespace TestAppForAbb.Core.Models
{
    public class Motor : AbstractEntity
    {
        public string Name { get; set; }

        public MotorType Type { get; set; }

        public double MaxPower { get; set; }

        public double? Voltage { get; set; }

        public double? FuelConsumption { get; set; }

        public double? Current { get; set; }

        public double? MaxTorque { get; set; }

        public double? MaxPressure { get; set; }

        public double? Displacement { get; set; }
    }
}
