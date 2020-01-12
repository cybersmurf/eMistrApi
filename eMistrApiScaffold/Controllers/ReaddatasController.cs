using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using eMistrApiScaffold.Models;

namespace eMistrApiScaffold.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReaddatasController : ControllerBase
    {
        private readonly datadashbContext _context;

        public ReaddatasController(datadashbContext context)
        {
            _context = context;
        }

        // GET: api/Readdatas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Readdata>>> GetReaddata()
        {
            return await _context.Readdata.ToListAsync();
        }

        // GET: api/Readdatas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Readdata>> GetReaddata(ulong id)
        {
            var readdata = await _context.Readdata.FindAsync(id);

            if (readdata == null)
            {
                return NotFound();
            }

            return readdata;
        }

        // PUT: api/Readdatas/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReaddata(ulong id, Readdata readdata)
        {
            if (id != readdata.Id)
            {
                return BadRequest();
            }

            _context.Entry(readdata).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReaddataExists(id))
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

        // POST: api/Readdatas
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Readdata>> PostReaddata(Readdata readdata)
        {
            _context.Readdata.Add(readdata);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReaddata", new { id = readdata.Id }, readdata);
        }

        // DELETE: api/Readdatas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Readdata>> DeleteReaddata(ulong id)
        {
            var readdata = await _context.Readdata.FindAsync(id);
            if (readdata == null)
            {
                return NotFound();
            }

            _context.Readdata.Remove(readdata);
            await _context.SaveChangesAsync();

            return readdata;
        }

        private bool ReaddataExists(ulong id)
        {
            return _context.Readdata.Any(e => e.Id == id);
        }
    }
}
