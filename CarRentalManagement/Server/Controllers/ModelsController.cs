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
    public class ModelsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public ModelsController (IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: Models
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Model>>> GetModels ( )
        {
            var Models = await unitOfWork.Models.GetAll ();
            return Ok (Models);
        }

        // GET: Models/5
        [HttpGet ("{id}")]
        public async Task<ActionResult<Model>> GetModel (int id)
        {
            var Model = await unitOfWork.Models.Get (m => m.Id == id);

            if (Model is null) return NotFound ();

            return Ok (Model);
        }

        // PUT: Models/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut ("{id}")]
        public async Task<IActionResult> PutModel (int id , Model Model)
        {
            if (id != Model.Id)
            {
                return BadRequest ();
            }

            unitOfWork.Models.Update (Model);

            try
            {
                await unitOfWork.Save (HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await ModelExists (id) is false)
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

        // POST: Models
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Model>> PostModel (Model Model)
        {
            await unitOfWork.Models.Insert (Model);
            await unitOfWork.Save (HttpContext);

            return CreatedAtAction ("GetModel" , new { id = Model.Id } , Model);
        }

        // DELETE: Models/5
        [HttpDelete ("{id}")]
        public async Task<IActionResult> DeleteModel (int id)
        {
            var Model = unitOfWork.Models.Get (m => m.Id == id);
            if (Model == null)
            {
                return NotFound ();
            }
            await unitOfWork.Models.Delete (id);
            await unitOfWork.Save (HttpContext);

            return NoContent ();
        }

        private async Task<bool> ModelExists (int id)
        {
            var Model = await unitOfWork.Models.Get (m => m.Id == id);
            return Model == null;
        }
    }
}
