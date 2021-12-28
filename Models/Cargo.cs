using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourierBid.Models
{
    public class Cargo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CargoId { get; set; }

        public CargoTypes CargoTypes { get; set; }
        [ForeignKey("CargoTypes")]
        public int CategoryId { get; set; }

        public string Weight { get; set; }

        public string Volume { get; set; }
    }
}
