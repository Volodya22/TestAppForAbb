using System.Collections.Generic;
using TestAppForAbb.Services.ViewModel;

namespace TestAppForAbb.Services.Interfaces
{
    /// <summary>
    /// Motors data Service
    /// </summary>
    public interface IMotorService
    {
        /// <summary>
        /// Select list of all Motors
        /// </summary>
        /// <returns>List of Motors</returns>
        List<MotorViewModel> Select();

        /// <summary>
        /// Create a Motor
        /// </summary>
        /// <param name="motor">Motor</param>
        /// <returns>Identifier of new object</returns>
        int Add(MotorViewModel motor);

        /// <summary>
        /// Update Motor data
        /// </summary>
        /// <param name="motor">Motor</param>
        void Update(MotorViewModel motor);

        /// <summary>
        /// Delete Motor
        /// </summary>
        /// <param name="motorId">Motor Identifier</param>
        void Delete(int motorId);
    }
}
