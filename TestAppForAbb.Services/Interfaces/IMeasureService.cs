using System.Collections.Generic;
using TestAppForAbb.Core.Models;
using TestAppForAbb.Services.ViewModel;

namespace TestAppForAbb.Services.Interfaces
{
    public interface IMeasureService : IService<Measure>
    {
        List<MeasureWithDifferenceViewModel> GetDifferences();
    }
}
