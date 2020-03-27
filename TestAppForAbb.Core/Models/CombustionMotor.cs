using System.Collections.Generic;
using TestAppForAbb.Core.Enum;

namespace TestAppForAbb.Core.Models
{
    public class CombustionMotor : AbstractEntity
    {
        public int MotorId { get; set; }

        public MotorType Type => MotorType.Electric;

        public double FuelConsumption { get; set; }

        public double MaxTorque { get; set; }

        public virtual Motor Motor { get; set; }

        public virtual ICollection<TorqueMeasure> TorqueMeasures { get; set; }
    }
}
