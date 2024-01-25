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
    public class FlightController : ControllerBase
    {
        private readonly Ace52024Context _context;

        public FlightController(Ace52024Context context)
        {
            _context = context;
        }

        // GET: api/Flight
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FlightsIvy>>> GetFlightsIvies()
        {
            return await _context.FlightsIvies.ToListAsync();
        }

        // GET: api/Flight/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FlightsIvy>> GetFlightsIvy(int id)
        {
            var flightsIvy = await _context.FlightsIvies.FindAsync(id);

            if (flightsIvy == null)
            {
                return NotFound();
            }

            return flightsIvy;
        }

        // PUT: api/Flight/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlightsIvy(int id, FlightsIvy flightsIvy)
        {
            if (id != flightsIvy.FlightId)
            {
                return BadRequest();
            }

            _context.Entry(flightsIvy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FlightsIvyExists(id))
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

        // POST: api/Flight
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FlightsIvy>> PostFlightsIvy(FlightsIvy flightsIvy)
        {
            _context.FlightsIvies.Add(flightsIvy);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FlightsIvyExists(flightsIvy.FlightId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFlightsIvy", new { id = flightsIvy.FlightId }, flightsIvy);
        }

        // DELETE: api/Flight/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFlightsIvy(int id)
        {
            var flightsIvy = await _context.FlightsIvies.FindAsync(id);
            if (flightsIvy == null)
            {
                return NotFound();
            }

            _context.FlightsIvies.Remove(flightsIvy);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FlightsIvyExists(int id)
        {
            return _context.FlightsIvies.Any(e => e.FlightId == id);
        }
    }
}
