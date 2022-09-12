using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Orders.Payments
{
    /// <summary>
    /// Payments
    /// </summary>
    [Table("Payment")]
    public class Payment : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        public Type PaymentType { get; set; }
        public int PaymentTypeId { get; set; }
        public Card PaymentCard { get; set; }
        public int PaymentCardId { get; set; }
        public IList<Order> Orders { get; set; }
    }
}