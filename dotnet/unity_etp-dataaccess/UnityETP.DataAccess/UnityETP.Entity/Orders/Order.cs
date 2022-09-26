using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Payments;
using UnityETP.Entity.Users;

namespace UnityETP.Entity.Orders
{
    /// <summary>
    /// Orders 
    /// </summary>
    [Table("UserOrders")]
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
        public string UserId { get; set; }
        public Detail Detail { get; set; }

        public IList<Item> OrderItems { get; set; }
    }
}