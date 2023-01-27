using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dot_NET_CRUD_Project.Models
{
    public class Buildings
    {
        [Key]
        public int PKBuilding { get; set; }

        [Required]
        [MaxLength]
        public string Building { get; set; } = string.Empty;

        public List<Customers>? Customers { get; set; }
    }
}
