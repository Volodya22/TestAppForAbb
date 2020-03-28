using System.Collections.Generic;

namespace TestAppForAbb.Core.Models
{
    /// <summary>
    /// Motor base class
    /// </summary>
    public class Motor : AbstractEntity
    {
        /// <summary>
        /// Name of Motor
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Max power (kW)
        /// </summary>
        public double MaxPower { get; set; }

        /// <summary>
        /// Is this Motor deleted
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Related Electric Motors
        /// </summary>
        public virtual ICollection<ElectricMotor> ElectricMotors { get; set; }

        /// <summary>
        /// Related Combustion Motors
        /// </summary>
        public virtual ICollection<CombustionMotor> CombustionMotors { get; set; }

        /// <summary>
        /// Related Hydraulic Motors
        /// </summary>
        public virtual ICollection<HydraulicMotor> HydraulicMotors { get; set; }
    }
}
