using System.ComponentModel.DataAnnotations.Schema;

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