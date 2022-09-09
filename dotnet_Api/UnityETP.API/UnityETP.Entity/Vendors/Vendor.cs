using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Vendors
{
    public class Vendor : BaseEntity<int>
    {
        public override int Id { get; set; }

        [Column] public DateTime? OrganizationCreated { get; set; }
        [Column] public byte Star { get; set; }

        public int ColorId { get; set; }
    }
}