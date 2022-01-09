using CourierBid.Data;
using CourierBid.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourierBid.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TransportsController : ControllerBase
    {
        private readonly ILogger<TransportsController> _logger;
        private readonly ApplicationContext _context;

        public TransportsController(ILogger<TransportsController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpGet]
        public IEnumerable<Transports> GetAll()
        {
            return _context.Transports.ToList();
        }

        [HttpGet("{id}")]
        public Transports GetTransportsId(int id)
        {
            return _context.Transports.FirstOrDefault(x => x.TransportId == id);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Transports transports)
        {
            _context.Add(transports);
            _context.SaveChanges();
            return Ok(transports);
        }

        [HttpPost]
        public IActionResult Update([FromBody] Transports transports)
        {
            var entity = _context.Transports.Attach(transports);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Ok(transports);
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            Transports transports = _context.Transports.FirstOrDefault(x => x.TransportId == id);
            _context.Remove(transports);
            _context.SaveChanges();
        }
    }
}
