using System.Collections.Generic;

namespace TestAppForAbb.Core.Models
{
    public class Motor : AbstractEntity
    {
        public string Name { get; set; }

        public double MaxPower { get; set; }

        public bool IsDeleted { get; set; }

        public virtual ICollection<ElectricMotor> ElectricMotors { get; set; }

        public virtual ICollection<CombustionMotor> CombustionMotors { get; set; }

        public virtual ICollection<HydraulicMotor> HydraulicMotors { get; set; }
    }
}
