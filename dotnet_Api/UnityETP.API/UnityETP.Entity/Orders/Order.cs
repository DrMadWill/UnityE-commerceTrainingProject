using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Orders
{
    public class Order : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Column] public decimal TotalPrice { get; set; }

        public int OrderStatusId { get; set; }
        public int PaymentId { get; set; }
    }
}