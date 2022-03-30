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
    public class columnsController : ControllerBase
    {
        private readonly restapiContext _context;

        public columnsController(restapiContext context)
        {
            _context = context;
        }

        // GET: api/columns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<columns>>> Getcolumns()
        {
            return await _context.columns.ToListAsync();
        }

        // GET: api/columns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<columns>> Getcolumns(long id)
        {
            var columns = await _context.columns.FindAsync(id);

            if (columns == null)
            {
                return NotFound();
            }

            return columns;
        }

        // PUT: api/columns/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putcolumns(long id, columns columns)
        {
            if (id != columns.id)
            {
                return BadRequest();
            }

            _context.Entry(columns).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!columnsExists(id))
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

        // POST: api/columns
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<columns>> Postcolumns(columns columns)
        {
            _context.columns.Add(columns);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getcolumns", new { id = columns.id }, columns);
        }

        // DELETE: api/columns/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletecolumns(long id)
        {
            var columns = await _context.columns.FindAsync(id);
            if (columns == null)
            {
                return NotFound();
            }

            _context.columns.Remove(columns);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool columnsExists(long id)
        {
            return _context.columns.Any(e => e.id == id);
        }
    }
}
