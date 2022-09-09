using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Orders
{
    public class StockToOrder : Modfiy
    {
        public int ProdcutStockId { get; set; }
        public int OrderId { get; set; }

        [Column] public int Count { get; set; }
        [Column] public decimal Price { get; set; }
        [Column] public decimal Discount { get; set; }
    }
}