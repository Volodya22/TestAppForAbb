using System.Collections.Generic;
using TestAppForAbb.Core.Enum;

namespace TestAppForAbb.Core.Models
{
    public class ElectricMotor : AbstractEntity
    {
        public int MotorId { get; set; }

        public MotorType Type => MotorType.Electric;

        public double Voltage { get; set; }

        public double Current { get; set; }

        public virtual Motor Motor { get; set; }

        public virtual ICollection<CurrentMeasure> CurrentMeasures { get; set; }
    }
}
