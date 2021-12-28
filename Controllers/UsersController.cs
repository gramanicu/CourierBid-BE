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
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly ApplicationContext _context;

        public UsersController(ILogger<UsersController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpGet]
        public IEnumerable<Users> GetAll()
        {
            return _context.Users.ToList();
        }

        [HttpGet("{id}")]
        public Users GetUserId(int id)
        {
            return _context.Users.FirstOrDefault(x => x.UserId == id);
        }

        [HttpPost]
        public void Add([FromBody] Users users)
        {
            _context.Add(users);
            _context.SaveChanges();
        }

        [HttpPost]
        public void Update([FromBody] Users users)
        {
            var entity = _context.Users.Attach(users);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            Users users = _context.Users.FirstOrDefault(x => x.UserId == id);
            _context.Remove(users);
            _context.SaveChanges();
        }
    }
}

