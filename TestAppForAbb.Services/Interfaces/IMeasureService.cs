using System.Collections.Generic;
using TestAppForAbb.Services.ViewModel;

namespace TestAppForAbb.Services.Interfaces
{
    public interface IMeasureService
    {
        List<MeasureWithDifferenceViewModel> Select();
    }
}
