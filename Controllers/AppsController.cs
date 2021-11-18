using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GestorApp.Models;

namespace GestorApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppsController : ControllerBase
    {
        private readonly GestorContext _context;

        public AppsController(GestorContext context)
        {
            _context = context;
        }

        // GET: api/Apps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Apps>>> GetApps()
        {
            return await _context.Apps.ToListAsync();
        }

        // GET: api/Apps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Apps>> GetApps(int id)
        {
            var apps = await _context.Apps.FindAsync(id);

            if (apps == null)
            {
                return NotFound();
            }

            return apps;
        }

        // PUT: api/Apps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApps(int id, Apps apps)
        {
            if (id != apps.AppsId)
            {
                return BadRequest();
            }

            _context.Entry(apps).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppsExists(id))
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

        // POST: api/Apps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Apps>> PostApps(Apps apps)
        {
            _context.Apps.Add(apps);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetApps", new { id = apps.AppsId }, apps);
        }

        // DELETE: api/Apps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApps(int id)
        {
            var apps = await _context.Apps.FindAsync(id);
            if (apps == null)
            {
                return NotFound();
            }

            _context.Apps.Remove(apps);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AppsExists(int id)
        {
            return _context.Apps.Any(e => e.AppsId == id);
        }
    }
}
