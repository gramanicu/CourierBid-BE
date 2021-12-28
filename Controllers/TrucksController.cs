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
    public class TrucksController : ControllerBase
    {
        private readonly ILogger<TrucksController> _logger;
        private readonly ApplicationContext _context;

        public TrucksController(ILogger<TrucksController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpGet]
        public IEnumerable<Trucks> GetAll()
        {
            return _context.Trucks.ToList();
        }

        [HttpGet("{id}")]
        public Trucks GetTruckId(int id)
        {
            return _context.Trucks.FirstOrDefault(x => x.TruckId == id);
        }

        [HttpPost]
        public void Add([FromBody] Trucks trucks)
        {
            _context.Add(trucks);
            _context.SaveChanges();
        }

        [HttpPost]
        public void Update([FromBody] Trucks trucks)
        {
            var entity = _context.Trucks.Attach(trucks);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            Trucks trucks = _context.Trucks.FirstOrDefault(x => x.TruckId == id);
            _context.Remove(trucks);
            _context.SaveChanges();
        }
    }
}
