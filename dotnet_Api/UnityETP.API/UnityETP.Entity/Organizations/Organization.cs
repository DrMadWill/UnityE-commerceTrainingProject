using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Organizations
{
    public class Organization : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Column] public string Name { get; set; }
        [Column] public string Description { get; set; }
        [Column] public string Tel { get; set; }
        [Column] public string Image { get; set; }

        public int VendorStatusId { get; set; }
        public int ContactId { get; set; }
    }
}