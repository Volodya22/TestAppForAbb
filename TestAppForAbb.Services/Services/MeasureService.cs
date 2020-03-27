using System.Linq;
using System.Collections.Generic;
using TestAppForAbb.DataLayer.Repository;
using TestAppForAbb.Services.Interfaces;
using TestAppForAbb.Services.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace TestAppForAbb.Services.Services
{
    public class MeasureService : IMeasureService
    {
        private readonly IRepository _context;

        public MeasureService(IRepository context)
        {
            _context = context;
        }

        public List<MeasureWithDifferenceViewModel> Select()
        {
            var torque = _context.TorqueMeasures.Include(m => m.Measure).Include(m => m.CombustionMotor).ThenInclude(m => m.Motor).AsEnumerable()
                .Select(m => new MeasureWithDifferenceViewModel(m)).ToList();
            var pressure = _context.PressureMeasures.Include(m => m.Measure).Include(m => m.HydraulicMotor).ThenInclude(m => m.Motor).AsEnumerable()
                .Select(m => new MeasureWithDifferenceViewModel(m)).ToList();
            var current = _context.CurrentMeasures.Include(m => m.Measure).Include(m => m.ElectricMotor).ThenInclude(m => m.Motor).AsEnumerable()
                .Select(m => new MeasureWithDifferenceViewModel(m)).ToList();

            torque.AddRange(pressure);
            torque.AddRange(current);

            torque = torque.OrderBy(e => e.MeasureId).ThenBy(e => e.MotorId).ToList();

            return torque;
        }
    }
}
