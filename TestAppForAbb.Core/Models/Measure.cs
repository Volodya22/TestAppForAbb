using System;
using System.Collections.Generic;

namespace TestAppForAbb.Core.Models
{
    public class Measure : AbstractEntity
    {
        public DateTime Time { get; set; }

        public virtual ICollection<CurrentMeasure> CurrentMeasures { get; set; }

        public virtual ICollection<TorqueMeasure> TorqueMeasures { get; set; }

        public virtual ICollection<PressureMeasure> PressureMeasures { get; set; }
    }
}
