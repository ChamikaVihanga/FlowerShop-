using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestFlower01.Server.Data;
using TestFlower01.Shared.Entities;

namespace TestFlower01.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OdersController : ControllerBase
    {
        private readonly AddDbContext _context;

        public OdersController(AddDbContext context)
        {
            _context = context;
        }

        // GET: api/Oders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Oder>>> GetOrders()
        {
            return await _context.Orders.ToListAsync();
        }

        // GET: api/Oders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Oder>> GetOder(int id)
        {
            var oder = await _context.Orders.FindAsync(id);

            if (oder == null)
            {
                return NotFound();
            }

            return oder;
        }

        // PUT: api/Oders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOder(int id, Oder oder)
        {
            if (id != oder.Id)
            {
                return BadRequest();
            }

            _context.Entry(oder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OderExists(id))
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

        // POST: api/Oders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Oder>> PostOder(Oder oder)
        {

            _context.Orders.Add(oder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOder", new { id = oder.Id }, oder);
        }

        // DELETE: api/Oders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOder(int id)
        {
            var oder = await _context.Orders.FindAsync(id);
            if (oder == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(oder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OderExists(int id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }
    }
}
