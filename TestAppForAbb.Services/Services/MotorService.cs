﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TestAppForAbb.Core.Enum;
using TestAppForAbb.Core.Models;
using TestAppForAbb.DataLayer.Repository;
using TestAppForAbb.Services.Interfaces;
using TestAppForAbb.Services.ViewModel;

namespace TestAppForAbb.Services.Services
{
    /// <inheritdoc cref="IMotorService" />
    public class MotorService : IMotorService
    {
        private readonly IRepository _context;

        public MotorService(IRepository context)
        {
            _context = context;
        }

        public List<MotorViewModel> Select()
        {
            var electric = _context.ElectricMotors.Where(m => !m.Motor.IsDeleted).Include(m => m.Motor).AsEnumerable()
                .Select(m => new MotorViewModel(m)).ToList();
            var hydraulic = _context.HydraulicMotors.Where(m => !m.Motor.IsDeleted).Include(m => m.Motor).AsEnumerable()
                .Select(m => new MotorViewModel(m)).ToList();
            var combustion = _context.CombustionMotors.Where(m => !m.Motor.IsDeleted).Include(m => m.Motor).AsEnumerable()
                .Select(m => new MotorViewModel(m)).ToList();

            electric.AddRange(hydraulic);
            electric.AddRange(combustion);

            electric = electric.OrderBy(m => m.MotorId).ToList();

            return electric;
        }

        public int Add(MotorViewModel motor) =>
            motor.Type switch
            {
                MotorType.Electric => AddElectricMotor(motor),
                MotorType.Hydraulic => AddHydraulicMotor(motor),
                MotorType.Combustion => AddCombustionMotor(motor),
                _ => throw new System.NotImplementedException()
            };

        public void Update(MotorViewModel motor)
        {
            switch(motor.Type)
            {
                case MotorType.Electric:
                    UpdateElectric(motor);
                    break;
                case MotorType.Hydraulic:
                    UpdateHydraulic(motor);
                    break;
                case MotorType.Combustion:
                    UpdateCombustion(motor);
                    break;
            }
        }

        public void Delete(int motorId)
        {
            var motorBase = _context.Motors.FirstOrDefault(m => m.Id == motorId);

            if (motorBase == null)
            {
                return;
            }

            motorBase.IsDeleted = true;

            _context.SaveChanges();
        }

        #region Creation

        private int AddElectricMotor(MotorViewModel motor)
        {
            var motorBase = AddBaseMotor(motor);

            var newMotor = new ElectricMotor
            {
                MotorId = motorBase.Id,
                Current = motor.Current ?? 0,
                Voltage = motor.Voltage ?? 0
            };

            _context.ElectricMotors.Add(newMotor);
            _context.SaveChanges();

            return newMotor.Id;
        }

        private int AddHydraulicMotor(MotorViewModel motor)
        {
            var motorBase = AddBaseMotor(motor);

            var newMotor = new HydraulicMotor
            {
                MotorId = motorBase.Id,
                Displacement = motor.Displacement ?? 0,
                MaxPressure = motor.MaxPressure ?? 0
            };

            _context.HydraulicMotors.Add(newMotor);
            _context.SaveChanges();

            return newMotor.Id;
        }

        private int AddCombustionMotor(MotorViewModel motor)
        {
            var motorBase = AddBaseMotor(motor);

            var newMotor = new CombustionMotor
            {
                MotorId = motorBase.Id,
                FuelConsumption = motor.FuelConsumption ?? 0,
                MaxTorque = motor.MaxTorque ?? 0
            };

            _context.CombustionMotors.Add(newMotor);
            _context.SaveChanges();

            return newMotor.Id;
        }

        private Motor AddBaseMotor(MotorViewModel motor)
        {
            var motorBase = new Motor()
            {
                Name = motor.Name,
                MaxPower = motor.MaxPower
            };

            _context.Motors.Add(motorBase);
            _context.SaveChanges();

            return motorBase;
        }

        #endregion

        #region Update

        private void UpdateElectric(MotorViewModel motor)
        {
            var toChange = _context.ElectricMotors.FirstOrDefault(m => m.Id == motor.Id);

            if (toChange == null)
            {
                return;
            }

            toChange.Voltage = motor.Voltage ?? 0;
            toChange.Current = motor.Current ?? 0;

            _context.SaveChanges();
        }

        private void UpdateHydraulic(MotorViewModel motor)
        {
            var toChange = _context.HydraulicMotors.FirstOrDefault(m => m.Id == motor.Id);

            if (toChange == null)
            {
                return;
            }

            toChange.MaxPressure = motor.MaxPressure ?? 0;
            toChange.Displacement = motor.Displacement ?? 0;

            _context.SaveChanges();
        }

        private void UpdateCombustion(MotorViewModel motor)
        {
            var toChange = _context.CombustionMotors.FirstOrDefault(m => m.Id == motor.Id);

            if (toChange == null)
            {
                return;
            }

            toChange.MaxTorque = motor.MaxTorque ?? 0;
            toChange.FuelConsumption = motor.FuelConsumption ?? 0;

            _context.SaveChanges();
        }

        #endregion
    }
}
