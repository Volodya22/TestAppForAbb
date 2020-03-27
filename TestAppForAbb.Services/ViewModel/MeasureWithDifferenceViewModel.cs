using TestAppForAbb.Core.Models;

namespace TestAppForAbb.Services.ViewModel
{
    public class MeasureWithDifferenceViewModel
    {
        private readonly Measure _measure;

        public MeasureWithDifferenceViewModel(Measure measure)
        {
            _measure = measure;
        }

        public double? TorqueDifference => _measure.Torque - _measure.Motor.MaxTorque;

        public double? CurrentDifference => _measure.Current - _measure.Motor.Current;

        public double? CurrentPressure => _measure.Pressure - _measure.Motor.MaxPressure;
    }
}
