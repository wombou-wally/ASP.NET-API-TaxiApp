using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaxiApp.Models;
namespace TaxiApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RidesController : ControllerBase
    {
        private TaxiDBContext context;
        public RidesController(TaxiDBContext DBcontext)
        {
            context = DBcontext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ride>>> GetRides()
        {
            var ride = await context.Rides.ToListAsync();
            return Ok(ride);
        }

        [HttpPost]
        public async Task<ActionResult<Ride>> PostRide( Ride ride)
        {
            context.Rides.Add(ride);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetRides), new { id = ride.RideId }, ride);
        }
    }
}
