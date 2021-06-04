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
    public class MakesController : BaseApiController
    {
        private readonly IUnitOfWork unitOfWork;

        public MakesController (IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: Makes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Make>>> GetMakes ( )
        {
            var Makes = await unitOfWork.Makes.GetAll ();
            return Ok (Makes);
        }

        // GET: Makes/5
        [HttpGet ("{id}")]
        public async Task<ActionResult<Make>> GetMake (int id)
        {
            var Make = await unitOfWork.Makes.Get (m => m.Id == id);

            if (Make is null) return NotFound ();

            return Ok (Make);
        }

        // PUT: Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut ("{id}")]
        public async Task<IActionResult> PutMake (int id , Make Make)
        {
            if (id != Make.Id)
            {
                return BadRequest ();
            }

            unitOfWork.Makes.Update (Make);

            try
            {
                await unitOfWork.Save (HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await MakeExists (id) is false)
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

        // POST: Makes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Make>> PostMake (Make Make)
        {
            await unitOfWork.Makes.Insert (Make);
            await unitOfWork.Save (HttpContext);

            return CreatedAtAction ("GetMake" , new { id = Make.Id } , Make);
        }

        // DELETE: Makes/5
        [HttpDelete ("{id}")]
        public async Task<IActionResult> DeleteMake (int id)
        {
            var Make = unitOfWork.Makes.Get (m => m.Id == id);
            if (Make == null)
            {
                return NotFound ();
            }
            await unitOfWork.Makes.Delete(id);
            await unitOfWork.Save(HttpContext);

            return NoContent ();
        }

        private async Task<bool> MakeExists (int id)
        {
            var Make = await unitOfWork.Makes.Get (m => m.Id == id);
            return Make == null;
        }
    }
}
