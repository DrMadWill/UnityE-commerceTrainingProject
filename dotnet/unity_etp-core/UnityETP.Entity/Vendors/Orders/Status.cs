using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityETP.Entity.Commons;

namespace UnityETP.Entity.Vendors.Orders
{
    /// <summary>
    /// Order Status
    /// </summary>
    [Table("VendorOrderStatus")]
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

        public IList<Order> VendorOrders { get; set; }
    }
}
