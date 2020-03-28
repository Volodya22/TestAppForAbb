using TestAppForAbb.Core.Enum;
using TestAppForAbb.Core.Models;

namespace TestAppForAbb.Services.ViewModel
{
    /// <summary>
    /// ViewModel for Motors
    /// </summary>
    public class MotorViewModel
    {
        public MotorViewModel()
        {

        }

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

        /// <summary>
        /// Identifier of Motor
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identifier of base Motor object
        /// </summary>
        public int MotorId { get; set; }

        /// <summary>
        /// Name of Motor
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Max Power (kW)
        /// </summary>
        public double MaxPower { get; set; }

        /// <summary>
        /// Type of Motor
        /// </summary>
        public MotorType Type { get; set; }

        /// <summary>
        /// Voltage (V)
        /// </summary>
        public double? Voltage { get; set; }

        /// <summary>
        /// Current (A)
        /// </summary>
        public double? Current { get; set; }

        /// <summary>
        /// Fuel Consumption per hour (l/h)
        /// </summary>
        public double? FuelConsumption { get; set; }

        /// <summary>
        /// Max Torque at (rpm)
        /// </summary>
        public double? MaxTorque { get; set; }

        /// <summary>
        /// Max Pressure (bar)
        /// </summary>
        public double? MaxPressure { get; set; }

        /// <summary>
        /// Displacement (cm3/rev)
        /// </summary>
        public double? Displacement { get; set; }
    }
}
