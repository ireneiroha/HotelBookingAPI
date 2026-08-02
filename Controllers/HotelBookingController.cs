using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HotelBookingAPI.Model;
using HotelBookingAPI.Data;

namespace HotelBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelBookingController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public HotelBookingController(ApiDbContext context)
        {
            _context = context;
        }

        // Create
        [HttpPost]
        public IActionResult Create(HotelBooking booking)
        {
            var existing = _context.Booking.Find(booking.Id);

            if (existing != null)
            {
                return Conflict($"A booking with id {booking.Id} already exists.");
            }

            _context.Booking.Add(booking);
            _context.SaveChanges();

            return Ok(booking);
        }

        // Update
        [HttpPut("{id}")]
        public IActionResult Update(int id, HotelBooking booking)
        {
            var bookingInDb = _context.Booking.Find(id);

            if (bookingInDb == null)
            {
                return NotFound();
            }

            bookingInDb.RoomNumber = booking.RoomNumber;
            bookingInDb.ClientName = booking.ClientName;

            _context.SaveChanges();

            return Ok(bookingInDb);
        }

        // Get
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _context.Booking.Find(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        // Get All
        [HttpGet]
        public IActionResult GetAll()
        {
            var bookings = _context.Booking.ToList();
            return Ok(bookings);
        }

        // Delete
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _context.Booking.Find(id);

            if (result == null)
                return NotFound();

            _context.Booking.Remove(result);
            _context.SaveChanges();

            return NoContent();
        }
    }
}