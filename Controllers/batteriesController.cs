#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using restapi.Models;

namespace restapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class batteriesController : ControllerBase
    {
        private readonly restapiContext _context;

        public batteriesController(restapiContext context)
        {
            _context = context;
        }

        // GET: api/batteries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<batteries>>> Getbatteries()
        {
            return await _context.batteries.ToListAsync();
        }

        // GET: api/batteries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<batteries>> Getbatteries(long id)
        {
            var batteries = await _context.batteries.FindAsync(id);

            if (batteries == null)
            {
                return NotFound();
            }

            return batteries;
        }

        // PUT: api/batteries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putbatteries(long id, batteries batteries)
        {
            if (id != batteries.id)
            {
                return BadRequest();
            }

            _context.Entry(batteries).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!batteriesExists(id))
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

        // POST: api/batteries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<batteries>> Postbatteries(batteries batteries)
        {
            _context.batteries.Add(batteries);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getbatteries", new { id = batteries.id }, batteries);
        }

        // DELETE: api/batteries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletebatteries(long id)
        {
            var batteries = await _context.batteries.FindAsync(id);
            if (batteries == null)
            {
                return NotFound();
            }

            _context.batteries.Remove(batteries);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool batteriesExists(long id)
        {
            return _context.batteries.Any(e => e.id == id);
        }
    }
}
