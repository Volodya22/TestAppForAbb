using System;

namespace TestAppForAbb.Core.Models
{
    public class Measure : AbstractEntity
    {
        public DateTime Time { get; set; }

        public int MotorId { get; set; }

        public double? Current { get; set; }

        public double? Torque { get; set; }

        public double? Pressure { get; set; }

        public virtual Motor Motor { get; set; }
    }
}
