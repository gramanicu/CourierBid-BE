using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace CourierBid.Models
{
    public class Transports
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransportId { get; set; }

        public Trucks Trucks { get; set; }
        [ForeignKey("Trucks")]
        public int TruckId { get; set; }

        public string Url { get; set; }

        public string StartLocation { get; set; }

        public string EndLocation { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

    }
}
