using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestAppForAbb.Core.Models;
using TestAppForAbb.Services.Interfaces;
using TestAppForAbb.Services.ViewModel;

namespace TestAppForAbb.Controllers
{
    /// <summary>
    /// Controller for opertions with Motors
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MotorController : ControllerBase
    {
        /// <summary>
        /// Motors Service
        /// </summary>
        private readonly IMotorService _motorService;

        public MotorController(IMotorService motorService)
        {
            _motorService = motorService;
        }

        /// <summary>
        /// Get list of all Motors
        /// </summary>
        /// <returns>List of Motors</returns>
        [HttpGet]
        public ActionResult<IEnumerable<MotorViewModel>> GetMotors()
        {
            return _motorService.Select();
        }

        /// <summary>
        /// Motor update
        /// </summary>
        /// <param name="id">Identifier of Motor</param>
        /// <param name="motor">Motor</param>
        /// <returns>Nothing, if successful</returns>
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

        /// <summary>
        /// Creation of Motor
        /// </summary>
        /// <param name="motor">Motor</param>
        /// <returns>Created Motor</returns>
        [HttpPost]
        public ActionResult<Motor> PostMotor(MotorViewModel motor)
        {
            _motorService.Add(motor);

            return CreatedAtAction("GetMotor", new { id = motor.Id }, motor);
        }

        /// <summary>
        /// Motor deletion
        /// </summary>
        /// <param name="motorId">Identifier of Motor base object</param>
        /// <returns>Ok, if successful</returns>
        [HttpDelete("{motorId}")]
        public IActionResult DeleteMotor(int motorId)
        {
            _motorService.Delete(motorId);

            return Ok();
        }
    }
}
