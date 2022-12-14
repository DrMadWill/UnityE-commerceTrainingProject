using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Commons;
using UnityETP.Entity.Organizations;
using UnityETP.Entity.Products;
using UnityETP.Entity.Vendors.Orders;

namespace UnityETP.Entity.Vendors
{
    [Table("Vendors")]
    public class Vendor : BaseEntity<int>
    {
        [Key, ForeignKey("Organizations")]
        public override int Id { get; set; }

        [Column] public DateTime? OrganizationCreated { get; set; }
        [Column] public float Star { get; set; }

        // Relation
        public Organization Organization { get; set; }
        public Color Color { get; set; }
        public int ColorId { get; set; }
        public IList<Prodcut> Prodcuts { get; set; }
        public IList<Order> VendorOrders { get; set; }
    }
}