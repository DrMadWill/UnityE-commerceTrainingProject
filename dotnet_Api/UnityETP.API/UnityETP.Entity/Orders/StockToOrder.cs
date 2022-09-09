using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityETP.Entity.Orders
{
    public class StockToOrder:Modfiy
    {
        public int ProdcutStockId { get; set; }
        public int OrderId { get; set; }

        [Column] public int Count { get; set; }
        [Column] public decimal Price { get; set; }
        [Column] public decimal Discount { get; set; }
    }
}
