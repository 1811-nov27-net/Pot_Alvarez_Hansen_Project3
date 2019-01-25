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
    public class OrderHeadersController : ControllerBase
    {
        private readonly Db_PegaOrdersContext _context;

        public OrderHeadersController(Db_PegaOrdersContext context)
        {
            _context = context;
        }

        // GET: api/OrderHeaders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderHeaders>>> GetOrderHeaders()
        {
            return await _context.OrderHeaders.ToListAsync();
        }

        // GET: api/OrderHeaders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderHeaders>> GetOrderHeaders(int id)
        {
            var orderHeaders = await _context.OrderHeaders.FindAsync(id);

            if (orderHeaders == null)
            {
                return NotFound();
            }

            return orderHeaders;
        }

        // PUT: api/OrderHeaders/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderHeaders(int id, OrderHeaders orderHeaders)
        {
            if (id != orderHeaders.Id)
            {
                return BadRequest();
            }

            _context.Entry(orderHeaders).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderHeadersExists(id))
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

        // POST: api/OrderHeaders
        [HttpPost]
        public async Task<ActionResult<OrderHeaders>> PostOrderHeaders(OrderHeaders orderHeaders)
        {
            _context.OrderHeaders.Add(orderHeaders);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrderHeaders", new { id = orderHeaders.Id }, orderHeaders);
        }

        // DELETE: api/OrderHeaders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<OrderHeaders>> DeleteOrderHeaders(int id)
        {
            var orderHeaders = await _context.OrderHeaders.FindAsync(id);
            if (orderHeaders == null)
            {
                return NotFound();
            }

            _context.OrderHeaders.Remove(orderHeaders);
            await _context.SaveChangesAsync();

            return orderHeaders;
        }

        private bool OrderHeadersExists(int id)
        {
            return _context.OrderHeaders.Any(e => e.Id == id);
        }
    }
}
