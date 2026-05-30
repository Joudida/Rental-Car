using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rentalcarbackend.Data;
using Rentalcarbackend.Models;

namespace Rentalcarbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BookingsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetBookings()
        {
            var bookings = _context.Bookings
                .Include(b => b.User)
                .Include(b => b.Car)
                .ToList();

            return Ok(bookings);
        }

        [HttpPost]
        public IActionResult CreateBooking(Booking booking)
        {
            var car = _context.Cars.Find(booking.CarId);

            if (car == null)
            {
                return NotFound(new
                {
                    message = "Car not found"
                });
            }

            if (car.Status == "Booked")
            {
                return BadRequest(new
                {
                    message = "Car already booked"
                });
            }

            car.Status = "Booked";

            _context.Bookings.Add(booking);
            _context.SaveChanges();

            return Ok(new
            {
                message = "Booking created successfully"
            });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var booking = _context.Bookings.Find(id);

            if (booking == null)
            {
                return NotFound();
            }

            _context.Bookings.Remove(booking);
            _context.SaveChanges();

            return Ok(new
            {
                message = "Booking deleted successfully"
            });
        }
    }
}