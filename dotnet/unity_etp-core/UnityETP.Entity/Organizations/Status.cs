using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Validations;

namespace UnityETP.Entity.Organizations
{
    /// <summary>
    /// Statuses Type
    /// </summary>
    [Table("OrganizationStatuses")]
    public class Status : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [StringLength(Limit.NameMaxLength, MinimumLength = Limit.NameMinLength)]
        [Column] public string Name { get; set; }

        // Relation
        public int ColorId { get; set; }

        public IList<Organization> Organizations { get; set; }
    }
}