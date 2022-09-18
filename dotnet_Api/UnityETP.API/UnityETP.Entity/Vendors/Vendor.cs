using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Commons;
using UnityETP.Entity.Organizations;
using UnityETP.Entity.Products;

namespace UnityETP.Entity.Vendors
{
    public class Vendor : BaseEntity<int>
    {
        [Key,ForeignKey("Organizations")]
        public override int Id { get; set; }

        [Column] public DateTime? OrganizationCreated { get; set; }
        [Column] public byte Star { get; set; }

        // Relation
        public Color Color { get; set; }
        public int ColorId { get; set; }
        public IList<Prodcut> Prodcuts { get; set; }
        public Organization Organization { get; set; }

    }
}