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
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace CarRentalManagement.Server.Controllers
{
    public class VehiclesController : BaseApiController
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IHttpContextAccessor httpContextAccessor;

        public VehiclesController (IUnitOfWork unitOfWork,IWebHostEnvironment webHostEnvironment,IHttpContextAccessor httpContextAccessor)
        {
            this.unitOfWork = unitOfWork;
            this.webHostEnvironment = webHostEnvironment;
            this.httpContextAccessor = httpContextAccessor;
        }

        // GET: Vehicles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehicles ( )
        {
            var includes = new List<string> { "Make" , "Model" , "Colour" };
            var Vehicles = await unitOfWork.Vehicles.GetAll (includes: includes);
            return Ok (Vehicles);
        }

        // GET: Vehicles/5
        [HttpGet ("{id}")]
        public async Task<ActionResult<Vehicle>> GetVehicle (int id)
        {
            var includes = new List<string> { "Make" , "Model" , "Colour" , "Bookings" };
            var Vehicle = await unitOfWork.Vehicles.Get (m => m.Id == id , includes: includes);

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

            if(Vehicle.Image.Length > 0)
            {
                Vehicle.ImageName = await CreateFile(Vehicle.Image , Vehicle.ImageName) ?? string.Empty;
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
            Vehicle.ImageName = await CreateFile(Vehicle.Image , Vehicle.ImageName);

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
            await unitOfWork.Vehicles.Delete (id);
            await unitOfWork.Save (HttpContext);

            return NoContent ();
        }

        private async Task<string> CreateFile(byte[] image , string name)
        {
            if (image.Length > 0)
            {
                var url = httpContextAccessor.HttpContext.Request.Host.Value;
                var path = Path.Combine (webHostEnvironment.WebRootPath , "Uploads" , "Images");
                
                if(!Directory.Exists(path)) Directory.CreateDirectory(path);
                
                path = Path.Combine(path  , name);
                var fstream = System.IO.File.Create (path);
                await fstream.WriteAsync (image , 0 , image.Length);
                fstream.Close ();
                name = $"https://{url}/Uploads/Images/{name}";
            }
            return name;
        }

        private async Task<bool> VehicleExists (int id)
        {
            var Vehicle = await unitOfWork.Vehicles.Get (m => m.Id == id);
            return Vehicle == null;
        }
    }
}
