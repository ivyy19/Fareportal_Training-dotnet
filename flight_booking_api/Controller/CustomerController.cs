using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using firstapi.Model;
using firstapi.Service;

namespace firstapi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustServ<CustomerIvy> _custserv;

        public CustomerController(ICustServ<CustomerIvy> custserv)
        {
            _custserv = custserv;
        }

        // GET: api/Customer
        [HttpGet]
        public async Task<IEnumerable<CustomerIvy>> GetCustomerIvies()
        {
            return await  _custserv.CustomIndex();
        }

        // GET: api/Customer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerIvy>> GetCustomerIvy(int id)
        {
            var customerIvy =  _custserv.GetCustById(id);

            if (customerIvy == null)
            {
                return NotFound();
            }

            return customerIvy;
        }

        // PUT: api/Customer/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerIvy(int id, CustomerIvy customerIvy)
        {
            if (id != customerIvy.CustomerId)
            {
                return BadRequest();
            }

          //  _context.Entry(customerIvy).State = EntityState.Modified;

            try
            {
                 _custserv.Edit(id,customerIvy);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerIvyExists(id))
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

        // POST: api/Customer
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CustomerIvy>> PostCustomerIvy(CustomerIvy customerIvy)
        {
          //  _context.CustomerIvies.Add(customerIvy);
            try
            {
                 _custserv.Create(customerIvy);
            }
            catch (DbUpdateException)
            {
                if (CustomerIvyExists(customerIvy.CustomerId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCustomerIvy", new { id = customerIvy.CustomerId }, customerIvy);
        }

        // DELETE: api/Customer/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomerIvy(int id)
        {
            var customerIvy =  _custserv.GetCustById(id);
            if (customerIvy == null)
            {
                return NotFound();
            }

            _custserv.Delete(id);
            //await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerIvyExists(int id)
        {
            CustomerIvy c=_custserv.GetCustById(id);
            if(c!=null)
            return true;
            else
            return false;
           // return _context.CustomerIvies.Any(e => e.CustomerId == id);
        }
    }
}
