using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityETP.Entity.Orders
{
    public class Detail : BaseEntity<int>
    {
        public override int Id { get; set; }
        [Column] public DateTime OrderDate { get; set; }

        [Column] public string Notes { get; set; }
        [Column] public DateTime RequiredDate { get; set; }

        public int ContactId { get; set; }
        public int ShipingId { get; set; }

    }
}
