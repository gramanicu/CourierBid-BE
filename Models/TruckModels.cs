using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourierBid.Models
{
    public class TruckModels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ModelId { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }
        public float Volume { get; set; }
        public string Dimensions { get; set; }
        public float Speed { get; set; }
    }
}
