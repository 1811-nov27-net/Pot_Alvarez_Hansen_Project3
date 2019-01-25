using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proj3API.Models;

namespace Proj3API.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogsController : ControllerBase
    {
        private readonly Db_PegaOrdersContext _context;

        public LogsController(Db_PegaOrdersContext context)
        {
            _context = context;
        }

        // GET: api/Logs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Logs>>> GetLogs()
        {
            return await _context.Logs.ToListAsync();
        }

        // GET: api/Logs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Logs>> GetLogs(int id)
        {
            var logs = await _context.Logs.FindAsync(id);

            if (logs == null)
            {
                return NotFound();
            }

            return logs;
        }

        // PUT: api/Logs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLogs(int id, Logs logs)
        {
            if (id != logs.Id)
            {
                return BadRequest();
            }

            _context.Entry(logs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LogsExists(id))
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

        // POST: api/Logs
        [HttpPost]
        public async Task<ActionResult<Logs>> PostLogs(Logs logs)
        {
            _context.Logs.Add(logs);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLogs", new { id = logs.Id }, logs);
        }

        // DELETE: api/Logs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Logs>> DeleteLogs(int id)
        {
            var logs = await _context.Logs.FindAsync(id);
            if (logs == null)
            {
                return NotFound();
            }

            _context.Logs.Remove(logs);
            await _context.SaveChangesAsync();

            return logs;
        }

        private bool LogsExists(int id)
        {
            return _context.Logs.Any(e => e.Id == id);
        }
    }
}
