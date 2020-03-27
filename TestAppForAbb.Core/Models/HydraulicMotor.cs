using System.Collections.Generic;
using TestAppForAbb.Core.Enum;

namespace TestAppForAbb.Core.Models
{
    public class HydraulicMotor : AbstractEntity
    {
        public int MotorId { get; set; }

        public MotorType Type => MotorType.Hydraulic;

        public double MaxPressure { get; set; }

        public double Displacement { get; set; }

        public virtual Motor Motor { get; set; }

        public virtual ICollection<PressureMeasure> PressureMeasures { get; set; }
    }
}
