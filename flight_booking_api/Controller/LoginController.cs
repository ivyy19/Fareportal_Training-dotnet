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
    public class LoginController : ControllerBase
    {
        private readonly Ace52024Context _context;

        public LoginController(Ace52024Context context)
        {
            _context = context;
        }

        // GET: api/Login
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IvyUser>>> GetIvyUsers()
        {
            return await _context.IvyUsers.ToListAsync();
        }

        // GET: api/Login/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IvyUser>> GetIvyUser(int id)
        {
            var ivyUser = await _context.IvyUsers.FindAsync(id);

            if (ivyUser == null)
            {
                return NotFound();
            }

            return ivyUser;
        }

        // PUT: api/Login/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIvyUser(int id, IvyUser ivyUser)
        {
            if (id != ivyUser.Id)
            {
                return BadRequest();
            }

            _context.Entry(ivyUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IvyUserExists(id))
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

        // POST: api/Login
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<IvyUser>> PostIvyUser(IvyUser ivyUser)
        {
            _context.IvyUsers.Add(ivyUser);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (IvyUserExists(ivyUser.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetIvyUser", new { id = ivyUser.Id }, ivyUser);
        }

        // DELETE: api/Login/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIvyUser(int id)
        {
            var ivyUser = await _context.IvyUsers.FindAsync(id);
            if (ivyUser == null)
            {
                return NotFound();
            }

            _context.IvyUsers.Remove(ivyUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IvyUserExists(int id)
        {
            return _context.IvyUsers.Any(e => e.Id == id);
        }
    }
}
