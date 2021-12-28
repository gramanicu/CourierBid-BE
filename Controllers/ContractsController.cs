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
    public class ContractsController : ControllerBase
    {
        private readonly ILogger<ContractsController> _logger;
        private readonly ApplicationContext _context;

        public ContractsController(ILogger<ContractsController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpGet]
        public IEnumerable<Contracts> GetAll()
        {
            return _context.Contracts.ToList();
        }

        [HttpGet("{id}")]
        public Contracts GetContractId(int id)
        {
            return _context.Contracts.FirstOrDefault(x => x.ContractId == id);
        }

        [HttpPost]
        public void Add([FromBody] Contracts contracts)
        {
            _context.Add(contracts);
            _context.SaveChanges();
        }

        [HttpPost]
        public void Update([FromBody] Contracts contracts)
        {
            var entity = _context.Contracts.Attach(contracts);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            Contracts contracts = _context.Contracts.FirstOrDefault(x => x.ContractId == id);
            _context.Remove(contracts);
            _context.SaveChanges();
        }
    }
}

