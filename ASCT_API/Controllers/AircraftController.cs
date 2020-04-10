using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASCT_API.Models;

namespace ASCT_API.Controllers
{
    [Route("api/aircraft")]
    [ApiController]
    public class AircraftController : ControllerBase
    {
        private readonly AircraftDBContext _context;

        public AircraftController(AircraftDBContext context)
        {
            _context = context;
        }

        // GET: api/Aircraft
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aircraft>>> GetAircrafts()
        {
            return await _context.Aircrafts.ToListAsync();
        }

        // GET: api/Aircraft/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Aircraft>> GetAircraft(string id)
        {
            var aircraft = await _context.Aircrafts.FindAsync(id);

            if (aircraft == null)
            {
                return NotFound();
            }

            return aircraft;
        }

        // PUT: api/Aircraft/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAircraft(string id, Aircraft aircraft)
        {
            if (id != aircraft.Tail_Number)
            {
                return BadRequest();
            }

            _context.Entry(aircraft).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AircraftExists(id))
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

        // POST: api/Aircraft
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Aircraft>> PostAircraft(Aircraft aircraft)
        {
            _context.Aircrafts.Add(aircraft);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AircraftExists(aircraft.Tail_Number))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAircraft", new { id = aircraft.Tail_Number }, aircraft);
        }

        // DELETE: api/Aircraft/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Aircraft>> DeleteAircraft(string id)
        {
            var aircraft = await _context.Aircrafts.FindAsync(id);
            if (aircraft == null)
            {
                return NotFound();
            }

            _context.Aircrafts.Remove(aircraft);
            await _context.SaveChangesAsync();

            return aircraft;
        }

        private bool AircraftExists(string id)
        {
            return _context.Aircrafts.Any(e => e.Tail_Number == id);
        }
    }
}
