using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestAppForAbb.Core.Enum;
using TestAppForAbb.Core.Models;
using TestAppForAbb.Services.Interfaces;
using TestAppForAbb.Services.ViewModel;

namespace TestAppForAbb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotorController : ControllerBase
    {
        private readonly IMotorService _motorService;

        public MotorController(IMotorService motorService)
        {
            _motorService = motorService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MotorViewModel>> GetMotors()
        {
            return _motorService.Select();
        }

        [HttpPut("{id}")]
        public IActionResult PutMotor(int id, MotorViewModel motor)
        {
            if (id != motor.Id)
            {
                return BadRequest();
            }

            try
            {
                _motorService.Update(motor);
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPost]
        public ActionResult<Motor> PostMotor(MotorViewModel motor)
        {
            _motorService.Add(motor);

            return CreatedAtAction("GetMotor", new { id = motor.Id }, motor);
        }

        [HttpDelete("{motorId}")]
        public IActionResult DeleteMotor(int motorId)
        {
            _motorService.Delete(motorId);

            return Ok();
        }
    }
}
