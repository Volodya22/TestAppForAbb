using System.Collections.Generic;
using TestAppForAbb.Core.Enum;

namespace TestAppForAbb.Core.Models
{
    /// <summary>
    /// Electric motor
    /// </summary>
    public class ElectricMotor : AbstractEntity
    {
        /// <summary>
        /// Identifier of motor base class
        /// </summary>
        public int MotorId { get; set; }

        /// <summary>
        /// Type of motor
        /// </summary>
        public MotorType Type => MotorType.Electric;

        /// <summary>
        /// Voltage (V)
        /// </summary>
        public double Voltage { get; set; }

        /// <summary>
        /// Current (A)
        /// </summary>
        public double Current { get; set; }

        /// <summary>
        /// Related Motor base
        /// </summary>
        public virtual Motor Motor { get; set; }

        /// <summary>
        /// Related measures of Current
        /// </summary>
        public virtual ICollection<CurrentMeasure> CurrentMeasures { get; set; }
    }
}
