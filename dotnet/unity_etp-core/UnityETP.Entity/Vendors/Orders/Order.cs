using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityETP.Entity.Payments;
using UnityETP.Entity.Users;

namespace UnityETP.Entity.Vendors.Orders
{
    /// <summary>
    /// Orders 
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
