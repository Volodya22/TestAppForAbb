using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TestAppForAbb.Services.Interfaces;
using TestAppForAbb.Services.ViewModel;

namespace TestAppForAbb.Controllers
{
    /// <summary>
    /// Controller for Measures
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MeasureController : ControllerBase
    {
        /// <summary>
        /// Measures Service
        /// </summary>
        private readonly IMeasureService _measureService;

        public MeasureController(IMeasureService measureService)
        {
            _measureService = measureService;
        }

        /// <summary>
        /// Get list of all Measures
        /// </summary>
        /// <returns>List of Measures</returns>
        [HttpGet]
        public ActionResult<IEnumerable<MeasureWithDifferenceViewModel>> GetMeasures()
        {
            return _measureService.Select();
        }
    }
}
