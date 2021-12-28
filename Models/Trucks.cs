﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CourierBid.Models
{
    public class Trucks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TruckId { get; set; }

        public TruckModels TruckModels { get; set; }
        [ForeignKey("TruckModels")]
        public int ModelId { get; set; }

        public Transports Transports { get; set; }
        [ForeignKey("Transports")]
        public int TransportId { get; set; }

        public float EmptyPrice { get; set; }

        public float FullPrice { get; set; }

        public string RegistryPlate { get; set; }
    }
}