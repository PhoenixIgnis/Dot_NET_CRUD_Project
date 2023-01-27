using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dot_NET_CRUD_Project.Models
{
    public class PartNumbers
    {
        [Key]
        public int PKPartNumber { get; set; }

        [MaxLength(50)]
        [Required]
        public string PartNumber { get; set; } = string.Empty;

        public bool Available { get; set; } = true;

        [ForeignKey("Customer")]
        public int FKCustomer { get; set; }
        public Customers? Customer { get; set; }
    }
}
