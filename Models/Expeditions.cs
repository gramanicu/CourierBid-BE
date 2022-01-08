using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using CourierBid.Data;

namespace CourierBid.Models
{
    public class Expeditions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExpeditionId { get; set; }
        public Cargo Cargo { get; set; }
        [ForeignKey("Cargo")]
        public int CargoId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }

        public string PickupLocation { get; set; }

        public string DeliveryLocation { get; set; }

        public DateTime PickupTime { get; set; }

        public DateTime DeliveryTime { get; set; }

        public DateTime PickupLimit { get; set; }

        public DateTime DeliveryLimit { get; set; }

        public float Budget { get; set; }
    }
}
