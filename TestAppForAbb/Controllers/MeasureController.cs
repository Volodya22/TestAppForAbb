using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TestAppForAbb.Services.Interfaces;
using TestAppForAbb.Services.ViewModel;

namespace TestAppForAbb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasureController : ControllerBase
    {
        private readonly IMeasureService _measureService;

        public MeasureController(IMeasureService measureService)
        {
            _measureService = measureService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MeasureWithDifferenceViewModel>> GetMeasures()
        {
            return _measureService.Select();
        }
    }
}
