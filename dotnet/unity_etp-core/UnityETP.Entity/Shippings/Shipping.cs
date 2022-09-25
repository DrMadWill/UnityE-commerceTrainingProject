using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Orders;
using UnityETP.Entity.Organizations;

namespace UnityETP.Entity.Shippings
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
        [NotMapped]
        public bool IsEnd { get => ArriveDate != null; }

        // Relation
        public Organization Organization { get; set; }
        public int OrganizationId { get; set; }

        public Status Status { get; set; }
        public int StatusId { get; set; }

        public IList<Orders.Detail> UserOrderDetails { get; set; }
        public IList<Vendors.Orders.Detail> VendorOrderDetails { get; set; }

    }
}