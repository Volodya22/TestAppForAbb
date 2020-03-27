using System.Linq;
using System.Collections.Generic;
using TestAppForAbb.Core.Models;
using TestAppForAbb.DataLayer.Repository;
using TestAppForAbb.Services.Interfaces;
using TestAppForAbb.Services.ViewModel;

namespace TestAppForAbb.Services.Services
{
    public class MeasureService : AbstractEntityService<Measure>, IMeasureService
    {
        public MeasureService(IRepository context) : base(context)
        {

        }

        public List<MeasureWithDifferenceViewModel> GetDifferences()
        {
            return Select().AsEnumerable().Select(m => new MeasureWithDifferenceViewModel(m)).ToList();
        }
    }
}
