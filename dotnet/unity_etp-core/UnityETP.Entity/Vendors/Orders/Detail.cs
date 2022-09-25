using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityETP.Entity.Contacts;
using UnityETP.Entity.Shippings;

namespace UnityETP.Entity.Vendors.Orders
{
    /// <summary>
    /// Order Details
    /// </summary>
    [Table("VendorOrderDetails")]
    public class Detail : BaseEntity<int>
    {
        [Key, ForeignKey("VendorOrders")]
        [Column]
        public override int Id { get; set; }
        [Column] public DateTime OrderDate { get; set; }
        [Column] public string Notes { get; set; }
        [Column] public DateTime RequiredDate { get; set; }
        
        // Relation 
        public Contact Contact { get; set; }
        public int ContactId { get; set; }

        public Shipping Shipping { get; set; }
        public int ShippingId { get; set; }

        public Order VendorOrder { get; set; }
    }
}
