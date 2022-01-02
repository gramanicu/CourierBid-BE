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
    public class CargoTypesController : ControllerBase
    {
        private readonly ILogger<CargoTypesController> _logger;
        private readonly ApplicationContext _context;

        public CargoTypesController(ILogger<CargoTypesController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpGet]
        public IEnumerable<CargoTypes> GetAll()
        {
            return _context.CargoTypes.ToList();
        }

        [HttpGet("{id}")]
        public CargoTypes GetCargoTypesId(int id)
        {
            return _context.CargoTypes.FirstOrDefault(x => x.CargoTypeId == id);
        }

        [HttpPost]
        public void Add([FromBody] CargoTypes cargoTypes)
        {
            _context.Add(cargoTypes);
            _context.SaveChanges();
        }

        [HttpPost]
        public void Update([FromBody] CargoTypes cargoTypes)
        {
            var entity = _context.CargoTypes.Attach(cargoTypes);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            CargoTypes cargoTypes = _context.CargoTypes.FirstOrDefault(x => x.CargoTypeId == id);
            _context.Remove(cargoTypes);
            _context.SaveChanges();
        }
    }
}
