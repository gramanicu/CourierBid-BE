using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourierBid.Models
{
    public class Contracts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContractId { get; set; }

        public Transports transports { get; set; }
        [ForeignKey("Transports")]
        public int TransportId { get; set; }

        public Expeditions Expeditions { get; set; }
        [ForeignKey("Expeditions")]
        public int ExpeditionId { get; set; }
    }
}
