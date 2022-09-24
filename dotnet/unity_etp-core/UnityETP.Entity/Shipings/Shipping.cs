using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Orders;

namespace UnityETP.Entity.Shipings
{
    /// <summary>
    /// Shippings 
    /// </summary>
    [Table("Shippings")]
    public class Shipping : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Column] public DateTime? ArriveDate { get; set; }

        [Column] public DateTime? StartDate { get; set; }

        public int OrganizationId { get; set; }

        [NotMapped]
        public bool IsEnd { get => ArriveDate != null; }

        // Relation
        public IList<Orders.Detail> UserOrderDetails { get; set; }
        public IList<Vendors.Orders.Detail> VendorOrderDetails { get; set; }

    }
}