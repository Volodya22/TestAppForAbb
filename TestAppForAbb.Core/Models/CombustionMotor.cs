using System.Collections.Generic;
using TestAppForAbb.Core.Enum;

namespace TestAppForAbb.Core.Models
{
    /// <summary>
    /// Combustion motor
    /// </summary>
    public class CombustionMotor : AbstractEntity
    {
        /// <summary>
        /// Identifier of motor base class
        /// </summary>
        public int MotorId { get; set; }

        /// <summary>
        /// Type of motor
        /// </summary>
        public MotorType Type => MotorType.Combustion;

        /// <summary>
        /// Fuel Comnsumption per hour (l/h)
        /// </summary>
        public double FuelConsumption { get; set; }

        /// <summary>
        /// Max Torque at (rpm)
        /// </summary>
        public double MaxTorque { get; set; }

        /// <summary>
        /// Motor base
        /// </summary>
        public virtual Motor Motor { get; set; }

        /// <summary>
        /// Related measures
        /// </summary>
        public virtual ICollection<TorqueMeasure> TorqueMeasures { get; set; }
    }
}
