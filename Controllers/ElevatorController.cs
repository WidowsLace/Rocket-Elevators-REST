#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAPI.Models;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElevatorController : ControllerBase
    {
        private readonly myapp_developmentContext _context;

        public ElevatorController(myapp_developmentContext context)
        {
            _context = context;
        }

        // GET: api/Elevator
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Elevator>>> GetElevators()
        {
            return await _context.Elevators.ToListAsync();
        }

        // GET: api/Elevator/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Elevator>> GetElevator(long id)
        {
            var elevator = await _context.Elevators.FindAsync(id);

            if (elevator == null)
            {
                return NotFound();
            }

            return elevator;
        }

        // PUT: api/Elevator/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElevator(long id, Elevator elevator)
        {
            if (id != elevator.Id)
            {
                return BadRequest();
            }

            _context.Entry(elevator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElevatorExists(id))
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

        // POST: api/Elevator
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Elevator>> PostElevator(Elevator elevator)
        {
            _context.Elevators.Add(elevator);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetElevator", new { id = elevator.Id }, elevator);
        }

        // DELETE: api/Elevator/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteElevator(long id)
        {
            var elevator = await _context.Elevators.FindAsync(id);
            if (elevator == null)
            {
                return NotFound();
            }

            _context.Elevators.Remove(elevator);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ElevatorExists(long id)
        {
            return _context.Elevators.Any(e => e.Id == id);
        }
    }
}
