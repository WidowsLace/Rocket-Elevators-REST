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
    public class elevatorsController : ControllerBase
    {
        private readonly restapiContext _context;

        public elevatorsController(restapiContext context)
        {
            _context = context;
        }

        // GET: api/elevators
        [HttpGet]
        public async Task<ActionResult<IEnumerable<elevators>>> Getelevators()
        {
            return await _context.elevators.ToListAsync();
        }

        // GET: api/elevators/5
        [HttpGet("{id}")]
        public async Task<ActionResult<elevators>> Getelevators(long id)
        {
            var elevators = await _context.elevators.FindAsync(id);

            if (elevators == null)
            {
                return NotFound();
            }

            return elevators;
        }

        // PUT: api/elevators/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putelevators(long id, elevators elevators)
        {
            if (id != elevators.id)
            {
                return BadRequest();
            }

            _context.Entry(elevators).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!elevatorsExists(id))
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

        // POST: api/elevators
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<elevators>> Postelevators(elevators elevators)
        {
            _context.elevators.Add(elevators);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getelevators", new { id = elevators.id }, elevators);
        }

        // DELETE: api/elevators/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteelevators(long id)
        {
            var elevators = await _context.elevators.FindAsync(id);
            if (elevators == null)
            {
                return NotFound();
            }

            _context.elevators.Remove(elevators);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool elevatorsExists(long id)
        {
            return _context.elevators.Any(e => e.id == id);
        }
    }
}
