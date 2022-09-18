using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Contacts;

namespace UnityETP.Entity.Orders
{
    /// <summary>
    /// Order Details
    /// </summary>
    [Table("OrderDetails")]
    public class Detail : BaseEntity<int>
    {
        [Key,ForeignKey("Orders")]
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

        public Order Order { get; set; }
    }
}