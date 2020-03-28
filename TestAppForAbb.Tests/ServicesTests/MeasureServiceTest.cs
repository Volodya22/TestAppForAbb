using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using TestAppForAbb.Core.Models;
using TestAppForAbb.DataLayer.Repository;
using TestAppForAbb.Services.Interfaces;
using TestAppForAbb.Services.Services;

namespace TestAppForAbb.Tests.ServicesTests
{
    [TestClass]
    public class MeasureServiceTest
    {
        private const int MeasuresCount = 3;

        private IRepository _repository;
        private IMeasureService _service;

        [TestMethod]
        public void TestGettingOnlyMeasuresForNotDeletedMotors()
        {
            var toDelete = _repository.Motors.FirstOrDefault();

            toDelete.IsDeleted = true;

            _repository.SaveChanges();

            var measures = _service.Select();

            Assert.AreEqual(measures.Count, MeasuresCount - 1);
        }

        [TestMethod]
        public void TestRecalculationAfterMotorUpdate()
        {
            var firstMeasure = _service.Select().FirstOrDefault(m => m.Current != null);
            var inc = 2;

            var eMotor = _repository.ElectricMotors.FirstOrDefault(m => m.MotorId == firstMeasure.MotorId);
            eMotor.Current += inc;
            _repository.SaveChanges();

            var secondMeasure = _service.Select().FirstOrDefault(m => m.Current != null);

            Assert.AreEqual(firstMeasure.CurrentDifference - inc, secondMeasure.CurrentDifference);
        }

        #region Initialization

        [TestInitialize]
        public void Init()
        {
            var options = new DbContextOptionsBuilder<MotorDbContext>()
                .UseInMemoryDatabase(databaseName: "MeasuresTest").Options;
            _repository = new MotorDbContext(options);

            Seed();

            _service = new MeasureService(_repository);
        }

        public void Seed()
        {
            var eMotorBase = new Motor
            {
                Name = "Test Electric Motor",
                MaxPower = 100
            };
            _repository.Motors.Add(eMotorBase);

            var cMotorBase = new Motor
            {
                Name = "Test Combustion Motor",
                MaxPower = 200
            };
            _repository.Motors.Add(cMotorBase);

            var hMotorBase = new Motor
            {
                Name = "Test Hydraulic Motor",
                MaxPower = 300
            };
            _repository.Motors.Add(hMotorBase);

            _repository.SaveChanges();

            var eMotor = new ElectricMotor
            {
                MotorId = eMotorBase.Id,
                Current = 10,
                Voltage = 100
            };
            _repository.ElectricMotors.Add(eMotor);

            var cMotor = new CombustionMotor
            {
                MotorId = cMotorBase.Id,
                FuelConsumption = 20,
                MaxTorque = 200
            };
            _repository.CombustionMotors.Add(cMotor);

            var hMotor = new HydraulicMotor
            {
                MotorId = hMotorBase.Id,
                MaxPressure = 30,
                Displacement = 300
            };
            _repository.HydraulicMotors.Add(hMotor);

            _repository.SaveChanges();

            var measure = new Measure
            {
                Time = DateTime.Now
            };
            _repository.Measures.Add(measure);

            _repository.SaveChanges();

            var cMeasure = new CurrentMeasure
            {
                MeasureId = measure.Id,
                ElectricMotorId = eMotor.Id,
                Current = 9
            };
            _repository.CurrentMeasures.Add(cMeasure);

            var tMeasure = new TorqueMeasure
            {
                MeasureId = measure.Id,
                CombustionMotorId = cMotor.Id,
                Torque = 21
            };
            _repository.TorqueMeasures.Add(tMeasure);

            var pMeasure = new PressureMeasure
            {
                MeasureId = measure.Id,
                HydraulicMotorId = hMotor.Id,
                Pressure = 33
            };
            _repository.PressureMeasures.Add(pMeasure);

            _repository.SaveChanges();
        }

        #endregion

        [TestCleanup]
        public void Cleanup()
        {
            _repository.CurrentMeasures.RemoveRange(_repository.CurrentMeasures);
            _repository.TorqueMeasures.RemoveRange(_repository.TorqueMeasures);
            _repository.PressureMeasures.RemoveRange(_repository.PressureMeasures);

            _repository.Measures.RemoveRange(_repository.Measures);

            _repository.ElectricMotors.RemoveRange(_repository.ElectricMotors);
            _repository.CombustionMotors.RemoveRange(_repository.CombustionMotors);
            _repository.HydraulicMotors.RemoveRange(_repository.HydraulicMotors);

            _repository.Motors.RemoveRange(_repository.Motors);
        }
    }
}
