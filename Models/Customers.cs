using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dot_NET_CRUD_Project.Models
{
    public class Customers
    {
        [Key]
        public int PKCustomers { get; set; }

        [Required]
        [MaxLength]
        public string Customer { get; set; } = string.Empty;

        [Required]
        [MaxLength(5)]
        public string Prefix { get; set; } = string.Empty;

        [ForeignKey("Building")]
        public int FKBuilding { get; set; }
        public Buildings? Building { get; set; }

        public List<PartNumbers>? PartNumbers { get; set; }

    }
}
