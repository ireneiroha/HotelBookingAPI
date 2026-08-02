using Microsoft.EntityFrameworkCore;
using HotelBookingAPI.Model;
namespace HotelBookingAPI.Data
{
    public class ApiDbContext : DbContext
    {

        public DbSet<HotelBooking> Booking { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {

        }
    }
}
