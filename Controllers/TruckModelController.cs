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
    public class TruckModelController : ControllerBase
    {
        private readonly ILogger<TruckModelController> _logger;
        private readonly ApplicationContext _context;

        public TruckModelController(ILogger<TruckModelController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpGet]
        public IEnumerable<TruckModels> GetAll()
        {
            return _context.TruckModels.ToList();
        }

        [HttpGet("{id}")]
        public TruckModels GetTruckId(int id)
        {
            return _context.TruckModels.FirstOrDefault(x => x.ModelId == id);
        }

        [HttpPost]
        public IActionResult Add([FromBody] TruckModels truckModels)
        {
            _context.Add(truckModels);
            _context.SaveChanges();
            return Ok(truckModels);
        }

        [HttpPost]
        public IActionResult Update([FromBody] TruckModels truckModels)
        {
            var entity = _context.TruckModels.Attach(truckModels);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Ok(truckModels);
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            TruckModels truckModels = _context.TruckModels.FirstOrDefault(x => x.ModelId == id);
            _context.Remove(truckModels);
            _context.SaveChanges();
        }
    }
}
