using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Commons;

namespace UnityETP.Entity.Orders
{
    /// <summary>
    /// Order Status
    /// </summary>
    [Table("OrderStatus")]
    public class Status : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [Column] public string Name { get; set; }

        // Region 
        public Color Color { get; set; }
        public int ColorId { get; set; }

        public IList<Order> Orders { get; set; }
    }
}