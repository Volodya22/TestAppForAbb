using System;
using TestAppForAbb.Core.Models;

namespace TestAppForAbb.Services.ViewModel
{
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

        public DateTime Time { get; set; }

        public int MeasureId { get; set; }

        public int MotorId { get; set; }

        public string MotorName { get; set; }

        public double? Current { get; set; }

        public double? CurrentDifference { get; set; }

        public double? Torque { get; set; }

        public double? TorqueDifference { get; set; }

        public double? Pressure { get; set; }

        public double? PressureDifference { get; set; }
    }
}
