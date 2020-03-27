using TestAppForAbb.Core.Enum;
using TestAppForAbb.Core.Models;

namespace TestAppForAbb.Services.ViewModel
{
    public class MotorViewModel
    {
        public MotorViewModel(ElectricMotor motor)
        {
            Id = motor.Id;
            MotorId = motor.MotorId;
            Name = motor.Motor.Name;
            MaxPower = motor.Motor.MaxPower;
            Type = motor.Type;
            Voltage = motor.Voltage;
            Current = motor.Current;
        }

        public MotorViewModel(CombustionMotor motor)
        {
            Id = motor.Id;
            MotorId = motor.MotorId;
            Name = motor.Motor.Name;
            MaxPower = motor.Motor.MaxPower;
            Type = motor.Type;
            FuelConsumption = motor.FuelConsumption;
            MaxTorque = motor.MaxTorque;
        }

        public MotorViewModel(HydraulicMotor motor)
        {
            Id = motor.Id;
            MotorId = motor.MotorId;
            Name = motor.Motor.Name;
            MaxPower = motor.Motor.MaxPower;
            Type = motor.Type;
            MaxPressure = motor.MaxPressure;
            Displacement = motor.Displacement;
        }

        public int Id { get; set; }

        public int MotorId { get; set; }

        public string Name { get; set; }

        public double MaxPower { get; set; }

        public MotorType Type { get; set; }

        public double? Voltage { get; set; }

        public double? Current { get; set; }

        public double? FuelConsumption { get; set; }

        public double? MaxTorque { get; set; }

        public double? MaxPressure { get; set; }

        public double? Displacement { get; set; }
    }
}
