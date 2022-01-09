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
    public class ExpeditionsController : ControllerBase
    {
        private readonly ILogger<ExpeditionsController> _logger;
        private readonly ApplicationContext _context;

        public ExpeditionsController(ILogger<ExpeditionsController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpGet]
        public IEnumerable<Expeditions> GetAll()
        {
            return _context.Expeditions.ToList();
        }

        [HttpGet("{id}")]
        public Expeditions GetExpeditionId(int id)
        {
            return _context.Expeditions.FirstOrDefault(x => x.ExpeditionId == id);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Expeditions expeditions)
        {
            _context.Add(expeditions);
            _context.SaveChanges();
            return Ok(expeditions);
        }

        [HttpPost]
        public IActionResult Update([FromBody] Expeditions expeditions)
        {
            var entity = _context.Expeditions.Attach(expeditions);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Ok(expeditions);
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            Expeditions expeditions = _context.Expeditions.FirstOrDefault(x => x.ExpeditionId == id);
            _context.Remove(expeditions);
            _context.SaveChanges();
        }
    }
}
