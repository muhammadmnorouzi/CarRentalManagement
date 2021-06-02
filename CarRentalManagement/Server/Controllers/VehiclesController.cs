using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;
using CarRentalManagement.Server.IRepository;

namespace CarRentalManagement.Server.Controllers
{
    [Route ("[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public VehiclesController (IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: Vehicles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehicles ( )
        {
            var Vehicles = await unitOfWork.Vehicles.GetAll ();
            return Ok (Vehicles);
        }

        // GET: Vehicles/5
        [HttpGet ("{id}")]
        public async Task<ActionResult<Vehicle>> GetVehicle (int id)
        {
            var Vehicle = await unitOfWork.Vehicles.Get (m => m.Id == id);

            if (Vehicle is null) return NotFound ();

            return Ok (Vehicle);
        }

        // PUT: Vehicles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut ("{id}")]
        public async Task<IActionResult> PutVehicle (int id , Vehicle Vehicle)
        {
            if (id != Vehicle.Id)
            {
                return BadRequest ();
            }

            unitOfWork.Vehicles.Update (Vehicle);

            try
            {
                await unitOfWork.Save (HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await VehicleExists (id) is false)
                {
                    return NotFound ();
                }
                else
                {
                    throw;
                }
            }

            return NoContent ();
        }

        // POST: Vehicles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vehicle>> PostVehicle (Vehicle Vehicle)
        {
            await unitOfWork.Vehicles.Insert (Vehicle);
            await unitOfWork.Save (HttpContext);

            return CreatedAtAction ("GetVehicle" , new { id = Vehicle.Id } , Vehicle);
        }

        // DELETE: Vehicles/5
        [HttpDelete ("{id}")]
        public async Task<IActionResult> DeleteVehicle (int id)
        {
            var Vehicle = unitOfWork.Vehicles.Get (m => m.Id == id);
            if (Vehicle == null)
            {
                return NotFound ();
            }
            await unitOfWork.Vehicles.Delete(id);
            await unitOfWork.Save(HttpContext);

            return NoContent ();
        }

        private async Task<bool> VehicleExists (int id)
        {
            var Vehicle = await unitOfWork.Vehicles.Get (m => m.Id == id);
            return Vehicle == null;
        }
    }
}
