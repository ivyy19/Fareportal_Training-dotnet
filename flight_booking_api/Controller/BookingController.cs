using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using firstapi.Model;

namespace firstapi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly Ace52024Context _context;

        public BookingController(Ace52024Context context)
        {
            _context = context;
        }

        // GET: api/Booking
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookingIvy>>> GetBookingIvies()
        {
            return await _context.BookingIvies.ToListAsync();
        }

        // GET: api/Booking/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookingIvy>> GetBookingIvy(int id)
        {
            var bookingIvy = await _context.BookingIvies.FindAsync(id);

            if (bookingIvy == null)
            {
                return NotFound();
            }

            return bookingIvy;
        }

        // PUT: api/Booking/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookingIvy(int id, BookingIvy bookingIvy)
        {
            if (id != bookingIvy.BookingId)
            {
                return BadRequest();
            }

            _context.Entry(bookingIvy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookingIvyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Booking
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookingIvy>> PostBookingIvy(BookingIvy bookingIvy)
        {
            _context.BookingIvies.Add(bookingIvy);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBookingIvy", new { id = bookingIvy.BookingId }, bookingIvy);
        }

        // DELETE: api/Booking/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookingIvy(int id)
        {
            var bookingIvy = await _context.BookingIvies.FindAsync(id);
            if (bookingIvy == null)
            {
                return NotFound();
            }

            _context.BookingIvies.Remove(bookingIvy);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookingIvyExists(int id)
        {
            return _context.BookingIvies.Any(e => e.BookingId == id);
        }
       // [HttpGet]
        // public async Task<IActionResult> CheckValidFlightAsync(string source, string destination)
        // {
        //     var validFlight=await CheckValidFlightAsync(source,destination);
        //     return Ok(validFlight);
        // }
    
    }
}
