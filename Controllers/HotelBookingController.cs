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

        // Create/Edit
        [HttpPost]
        public JsonResult CreateEdit(HotelBooking booking)
        {
            if (booking.Id == 0)
            {
                _context.Booking.Add(booking);
            }
            else
            {
                var bookingInDb = _context.Booking.Find(booking.Id);

                if (bookingInDb == null)
                {
                    return new JsonResult(NotFound());
                }

                bookingInDb.RoomNumber = booking.RoomNumber;
                bookingInDb.ClientName = booking.ClientName;
            }

            _context.SaveChanges();

            return new JsonResult(Ok(booking));
        }
    }
}