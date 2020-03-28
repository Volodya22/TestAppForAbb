using System.Collections.Generic;
using TestAppForAbb.Core.Enum;

namespace TestAppForAbb.Core.Models
{
    /// <summary>
    /// Hydraulic motor
    /// </summary>
    public class HydraulicMotor : AbstractEntity
    {
        /// <summary>
        /// Identifier of motor base class
        /// </summary>
        public int MotorId { get; set; }

        /// <summary>
        /// Type of motor
        /// </summary>
        public MotorType Type => MotorType.Hydraulic;

        /// <summary>
        /// Max Pressure (bar)
        /// </summary>
        public double MaxPressure { get; set; }

        /// <summary>
        /// Displacement (cm3/rev)
        /// </summary>
        public double Displacement { get; set; }

        /// <summary>
        /// Related Motor base
        /// </summary>
        public virtual Motor Motor { get; set; }

        /// <summary>
        /// Related measures of Pressure
        /// </summary>
        public virtual ICollection<PressureMeasure> PressureMeasures { get; set; }
    }
}
