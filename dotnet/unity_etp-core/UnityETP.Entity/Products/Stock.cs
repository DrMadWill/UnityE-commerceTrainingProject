using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Products
{
    /// <summary>
    /// Product Stocks Table
    /// </summary>
    [Table("ProductStocks")]
    public class Stock : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Column] public DateTime LifeTime { get; set; }
        [Column] public bool IsEnd { get; set; }
        [Column] public string SKU { get; set; }

        public Prodcut Prodcut { get; set; }
        public int PorductId { get; set; }

        public Size ProductSize { get; set; }
        public int ProductSizeId { get; set; }

        public IList<Orders.Item> UserOrderItems { get; set; }
        public IList<Vendors.Orders.Item> VendorOrderItems { get; set; }
    }
}