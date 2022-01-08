using CourierBid.Models;
using Microsoft.AspNetCore.Identity;

namespace CourierBid.Data
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Role { get; set; }
        public virtual Expeditions Expeditions { get; set; }
        public virtual Trucks Transports { get; set; }
    }
}
