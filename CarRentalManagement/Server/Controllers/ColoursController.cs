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
    public class ColoursController : BaseApiController
    {
        private readonly IUnitOfWork unitOfWork;

        public ColoursController (IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: Colours
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Colour>>> GetColours ( )
        {
            var Colours = await unitOfWork.Colours.GetAll ();
            return Ok (Colours);
        }

        // GET: Colours/5
        [HttpGet ("{id}")]
        public async Task<ActionResult<Colour>> GetColour (int id)
        {
            var Colour = await unitOfWork.Colours.Get (m => m.Id == id);

            if (Colour is null) return NotFound ();

            return Ok (Colour);
        }

        // PUT: Colours/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut ("{id}")]
        public async Task<IActionResult> PutColour (int id , Colour Colour)
        {
            if (id != Colour.Id)
            {
                return BadRequest ();
            }

            unitOfWork.Colours.Update (Colour);

            try
            {
                await unitOfWork.Save (HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await ColourExists (id) is false)
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

        // POST: Colours
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Colour>> PostColour (Colour Colour)
        {
            await unitOfWork.Colours.Insert (Colour);
            await unitOfWork.Save (HttpContext);

            return CreatedAtAction ("GetColour" , new { id = Colour.Id } , Colour);
        }

        // DELETE: Colours/5
        [HttpDelete ("{id}")]
        public async Task<IActionResult> DeleteColour (int id)
        {
            var Colour = unitOfWork.Colours.Get (m => m.Id == id);
            if (Colour == null)
            {
                return NotFound ();
            }
            await unitOfWork.Colours.Delete(id);
            await unitOfWork.Save(HttpContext);

            return NoContent ();
        }

        private async Task<bool> ColourExists (int id)
        {
            var Colour = await unitOfWork.Colours.Get (m => m.Id == id);
            return Colour == null;
        }
    }
}
