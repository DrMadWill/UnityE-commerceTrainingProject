using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Orders.Payments;
using UnityETP.Entity.Users;

namespace UnityETP.Entity.Orders
{
    /// <summary>
    /// Orders 
    /// </summary>
    [Table("Orders")]
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
        public AppUser User { get; set; }
        public int UserId { get; set; }
        public Detail Detail { get; set; }

        public IList<StockToOrder> StockToOrders { get; set; }
    }
}