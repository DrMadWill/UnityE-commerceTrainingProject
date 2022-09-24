using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Orders;

namespace UnityETP.Entity.Payments
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
        public IList<Orders.Order> UserOrders { get; set; }
        public IList<Vendors.Orders.Order> VendorOrders { get; set; }


    }
}