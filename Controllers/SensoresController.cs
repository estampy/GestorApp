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
    public class SensoresController : ControllerBase
    {
        private readonly GestorContext _context;

        public SensoresController(GestorContext context)
        {
            _context = context;
        }

        // GET: api/Sensores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sensores>>> GetSensores()
        {
            return await _context.Sensores.ToListAsync();
        }

        // GET: api/Sensores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sensores>> GetSensores(int id)
        {
            var sensores = await _context.Sensores.FindAsync(id);

            if (sensores == null)
            {
                return NotFound();
            }

            return sensores;
        }

        // PUT: api/Sensores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSensores(int id, Sensores sensores)
        {
            if (id != sensores.SensoresId)
            {
                return BadRequest();
            }

            _context.Entry(sensores).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SensoresExists(id))
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

        // POST: api/Sensores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sensores>> PostSensores(Sensores sensores)
        {
            _context.Sensores.Add(sensores);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSensores", new { id = sensores.SensoresId }, sensores);
        }

        // DELETE: api/Sensores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSensores(int id)
        {
            var sensores = await _context.Sensores.FindAsync(id);
            if (sensores == null)
            {
                return NotFound();
            }

            _context.Sensores.Remove(sensores);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SensoresExists(int id)
        {
            return _context.Sensores.Any(e => e.SensoresId == id);
        }
    }
}
