using System.Collections.Generic;
using TestAppForAbb.Services.ViewModel;

namespace TestAppForAbb.Services.Interfaces
{
    /// <summary>
    /// Measures data Service
    /// </summary>
    public interface IMeasureService
    {
        /// <summary>
        /// Selecting measures data
        /// </summary>
        /// <returns>List of measures</returns>
        List<MeasureWithDifferenceViewModel> Select();
    }
}
