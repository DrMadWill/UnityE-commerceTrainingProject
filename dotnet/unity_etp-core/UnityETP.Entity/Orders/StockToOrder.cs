using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Products;

namespace UnityETP.Entity.Orders
{
    /// <summary>
    /// Stock To Order Connection  
    /// </summary>
    [Table("StockToOrders")]
    public class StockToOrder : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        public Stock ProdcutStock { get; set; }
        public int ProdcutStockId { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }

        [Column] public int Count { get; set; }
        [Column] public decimal Price { get; set; }
        [Column] public decimal Discount { get; set; }
    }
}