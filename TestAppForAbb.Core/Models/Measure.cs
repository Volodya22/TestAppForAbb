using System;
using System.Collections.Generic;

namespace TestAppForAbb.Core.Models
{
    /// <summary>
    /// Measure base class
    /// </summary>
    public class Measure : AbstractEntity
    {
        /// <summary>
        /// Time of measurement
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// Related measures of Current
        /// </summary>
        public virtual ICollection<CurrentMeasure> CurrentMeasures { get; set; }

        /// <summary>
        /// Related measures of Torque
        /// </summary>
        public virtual ICollection<TorqueMeasure> TorqueMeasures { get; set; }

        /// <summary>
        /// Related measures of Pressure
        /// </summary>
        public virtual ICollection<PressureMeasure> PressureMeasures { get; set; }
    }
}
