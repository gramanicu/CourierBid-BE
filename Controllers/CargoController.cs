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
    public class CargoController : ControllerBase
    {
        private readonly ILogger<CargoController> _logger;
        private readonly ApplicationContext _context;

        public CargoController(ILogger<CargoController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpGet]
        public IEnumerable<Cargo> GetAll()
        {
            return _context.Cargo.ToList();
        }

        [HttpGet("{id}")]
        public Cargo GetCargoId(int id)
        {
            return _context.Cargo.FirstOrDefault(x => x.CargoId == id);
        }

        [HttpPost]
        public void Add([FromBody] Cargo cargo)
        {
            _context.Add(cargo);
            _context.SaveChanges();
        }

        [HttpPost]
        public void Update([FromBody] Cargo cargo)
        {
            var entity = _context.Cargo.Attach(cargo);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            Cargo cargo = _context.Cargo.FirstOrDefault(x => x.CargoId == id);
            _context.Remove(cargo);
            _context.SaveChanges();
        }
    }
}
