using System;
using TestAppForAbb.Core.Models;

namespace TestAppForAbb.Services.ViewModel
{
    /// <summary>
    /// ViewModel for Measure
    /// </summary>
    public class MeasureWithDifferenceViewModel
    {
        public MeasureWithDifferenceViewModel(TorqueMeasure measure)
        {
            MeasureId = measure.MeasureId;
            Time = measure.Measure.Time;
            MotorId = measure.CombustionMotor.MotorId;
            MotorName = measure.CombustionMotor.Motor.Name;
            Torque = measure.Torque;
            TorqueDifference = measure.Torque - measure.CombustionMotor.MaxTorque;
        }

        public MeasureWithDifferenceViewModel(PressureMeasure measure)
        {
            MeasureId = measure.MeasureId;
            Time = measure.Measure.Time;
            MotorId = measure.HydraulicMotor.MotorId;
            MotorName = measure.HydraulicMotor.Motor.Name;
            Pressure = measure.Pressure;
            PressureDifference = measure.Pressure - measure.HydraulicMotor.MaxPressure;
        }

        public MeasureWithDifferenceViewModel(CurrentMeasure measure)
        {
            MeasureId = measure.MeasureId;
            Time = measure.Measure.Time;
            MotorId = measure.ElectricMotor.MotorId;
            MotorName = measure.ElectricMotor.Motor.Name;
            Current = measure.Current;
            CurrentDifference = measure.Current - measure.ElectricMotor.Current;
        }

        /// <summary>
        /// Time of measurment
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// Identifier of Measure base object
        /// </summary>
        public int MeasureId { get; set; }

        /// <summary>
        /// Identifier of related Motor
        /// </summary>
        public int MotorId { get; set; }

        /// <summary>
        /// Name of related Motor
        /// </summary>
        public string MotorName { get; set; }

        /// <summary>
        /// Value of Current
        /// </summary>
        public double? Current { get; set; }

        /// <summary>
        /// Difference for Current
        /// </summary>
        public double? CurrentDifference { get; set; }

        /// <summary>
        /// Value of Torque
        /// </summary>
        public double? Torque { get; set; }

        /// <summary>
        /// Difference for Torque
        /// </summary>
        public double? TorqueDifference { get; set; }

        /// <summary>
        /// Value of Pressure
        /// </summary>
        public double? Pressure { get; set; }

        /// <summary>
        /// Difference for Pressure
        /// </summary>
        public double? PressureDifference { get; set; }
    }
}
