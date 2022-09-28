using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Payments;

namespace UnityETP.Entity.Vendors.Orders
{
    /// <summary>
    /// Vendor Orders
    /// </summary>
    [Table("VendorOrders")]
    public class Order : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Column] public decimal TotalPrice { get; set; }

        // Relation
        public Status Status { get; set; }

        public int StatusId { get; set; }
        public Payment Payment { get; set; }
        public int PaymentId { get; set; }
        public Vendor Vendor { get; set; }
        public int UserId { get; set; }
        public Detail Detail { get; set; }
        public IList<Item> VendorOrderItems { get; set; }
    }
}