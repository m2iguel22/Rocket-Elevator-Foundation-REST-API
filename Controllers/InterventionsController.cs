using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rocket_Rest.Models;

namespace Rocket_Rest.Controllers
{
    [Route("api/interventions")]
    [ApiController]
    public class InterventionsController : ControllerBase
    {
        private readonly Rocket_RestContext _context;

        public InterventionsController(Rocket_RestContext context)
        {
            _context = context;
        }

        // GET: api/Intervent
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Intervention>>> GetInterventionItems()
        {
            return await _context.interventions.ToListAsync();
        }

        // GET: api/Intervention/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Intervention>> GetIntervention(long id)
        {
            var intervention = await _context.interventions.FindAsync(id);

            if (intervention == null)
            {
                return NotFound();
            }

            return intervention;
        }

        // PUT: api/Intervention/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIntervention(long id, Intervention intervention)
        {
            if (id != intervention.id)
            {
                return BadRequest();
            }

            _context.Entry(intervention).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InterventionExists(id))
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

        // POST: api/Intervention
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Intervention>> PostIntervention(Intervention intervention)
        {
            _context.interventions.Add(intervention);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIntervention", new { id = intervention.id }, intervention);
        }

        // DELETE: api/intervention/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Intervention>> DeleteIntervention(long id)
        {
            var intervention = await _context.interventions.FindAsync(id);
            if (intervention == null)
            {
                return NotFound();
            }

            _context.interventions.Remove(intervention);
            await _context.SaveChangesAsync();

            return intervention;
        }

        private bool InterventionExists(long id)
        {
            return _context.interventions.Any(e => e.id == id);
        }

        // GET: api/intervention/pending
        
        [HttpGet("Pending")]
        public IEnumerable<Intervention> GetInterventionPending()
        {
        
            IQueryable<Intervention> status = from iStatus in _context.interventions where iStatus.status == "Pending" && iStatus.Interventions_date_time_end == null select iStatus;
            
            return status;
        }

        [HttpPut("changeStatus/{id}")]

        public string changeStatusIntervention (long id) {
            var interventions = _context.interventions.Find(id);
            
                interventions.status = "InProgress";               
                interventions.Interventions_date_time_start = DateTime.Now;
                _context.interventions.Update (interventions);
                _context.SaveChanges ();
                return "The intervention status change is done ";
            }   
        
        [HttpPut("updateStatus/{id}")]

        public string changeUpdateIntervention  (long id) {
            var interventions = _context.interventions.Find(id);
                interventions.result = "Great Success!";
                interventions.status = "Complete";               
                interventions.Interventions_date_time_end = DateTime.Now;
                _context.interventions.Update (interventions);
                _context.SaveChanges ();
                return "The intervention status is update";
            }   
    }
}