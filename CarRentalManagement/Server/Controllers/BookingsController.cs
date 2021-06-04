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
    public class BookingsController : BaseApiController
    {
        private readonly IUnitOfWork unitOfWork;

        public BookingsController (IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: Bookings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Booking>>> GetBookings ( )
        {
            var includes = new List<string> { "Vehicle" , "Customer"};
            var Bookings = await unitOfWork.Bookings.GetAll (includes:includes);
            return Ok (Bookings);
        }

        // GET: Bookings/5
        [HttpGet ("{id}")]
        public async Task<ActionResult<Booking>> GetBooking (int id)
        {
            var includes = new List<string> { "Vehicle" , "Customer" };
            var Booking = await unitOfWork.Bookings.Get (m => m.Id == id, includes: includes);

            if (Booking is null) return NotFound ();

            return Ok (Booking);
        }

        // PUT: Bookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut ("{id}")]
        public async Task<IActionResult> PutBooking (int id , Booking Booking)
        {
            if (id != Booking.Id)
            {
                return BadRequest ();
            }

            unitOfWork.Bookings.Update (Booking);

            try
            {
                await unitOfWork.Save (HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await BookingExists (id) is false)
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

        // POST: Bookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Booking>> PostBooking (Booking Booking)
        {
            await unitOfWork.Bookings.Insert (Booking);
            await unitOfWork.Save (HttpContext);

            return CreatedAtAction ("GetBooking" , new { id = Booking.Id } , Booking);
        }

        // DELETE: Bookings/5
        [HttpDelete ("{id}")]
        public async Task<IActionResult> DeleteBooking (int id)
        {
            var Booking = unitOfWork.Bookings.Get (m => m.Id == id);
            if (Booking == null)
            {
                return NotFound ();
            }
            await unitOfWork.Bookings.Delete(id);
            await unitOfWork.Save(HttpContext);

            return NoContent ();
        }

        private async Task<bool> BookingExists (int id)
        {
            var Booking = await unitOfWork.Bookings.Get (m => m.Id == id);
            return Booking == null;
        }
    }
}
