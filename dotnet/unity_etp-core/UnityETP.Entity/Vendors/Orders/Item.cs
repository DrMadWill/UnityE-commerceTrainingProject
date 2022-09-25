using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityETP.Entity.Products;

namespace UnityETP.Entity.Vendors.Orders
{
    /// <summary>
    /// Stock To Order Connection  
    /// </summary>
    [Table("VendorOrderItems")]
    public class Item : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        [Column] public int Count { get; set; }
        [Column] public decimal Price { get; set; }
        [Column] public decimal Discount { get; set; }

        // Relation
        public Stock ProdcutStock { get; set; }
        public int ProdcutStockId { get; set; } 
        public Order VendorOrder { get; set; }
        public int OrderId { get; set; }
    }
}
