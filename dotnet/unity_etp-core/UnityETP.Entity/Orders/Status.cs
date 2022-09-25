using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Commons;
using UnityETP.Entity.Validations;

namespace UnityETP.Entity.Orders
{
    /// <summary>
    /// Order Status
    /// </summary>
    [Table("UserOrderStatus")]
    public class Status : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [StringLength(Limit.NameMaxLength, MinimumLength = Limit.NameMinLength)]
        [Column] public string Name { get; set; }

        // Region 
        public Color Color { get; set; }
        public int ColorId { get; set; }

        public IList<Order> UserOrders { get; set; }
    }
}