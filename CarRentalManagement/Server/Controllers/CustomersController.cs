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
    public class CustomersController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public CustomersController (IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers ( )
        {
            var Customers = await unitOfWork.Customers.GetAll ();
            return Ok (Customers);
        }

        // GET: Customers/5
        [HttpGet ("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer (int id)
        {
            var Customer = await unitOfWork.Customers.Get (m => m.Id == id);

            if (Customer is null) return NotFound ();

            return Ok (Customer);
        }

        // PUT: Customers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut ("{id}")]
        public async Task<IActionResult> PutCustomer (int id , Customer Customer)
        {
            if (id != Customer.Id)
            {
                return BadRequest ();
            }

            unitOfWork.Customers.Update (Customer);

            try
            {
                await unitOfWork.Save (HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await CustomerExists (id) is false)
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

        // POST: Customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer (Customer Customer)
        {
            await unitOfWork.Customers.Insert (Customer);
            await unitOfWork.Save (HttpContext);

            return CreatedAtAction ("GetCustomer" , new { id = Customer.Id } , Customer);
        }

        // DELETE: Customers/5
        [HttpDelete ("{id}")]
        public async Task<IActionResult> DeleteCustomer (int id)
        {
            var Customer = unitOfWork.Customers.Get (m => m.Id == id);
            if (Customer == null)
            {
                return NotFound ();
            }
            await unitOfWork.Customers.Delete(id);
            await unitOfWork.Save(HttpContext);

            return NoContent ();
        }

        private async Task<bool> CustomerExists (int id)
        {
            var Customer = await unitOfWork.Customers.Get (m => m.Id == id);
            return Customer == null;
        }
    }
}
