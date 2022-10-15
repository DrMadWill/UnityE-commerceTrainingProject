using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Validations;

namespace UnityETP.Entity.Contacts
{
    /// <summary>
    /// Address => Region
    /// </summary>
    [Table("Regions")]
    public class Region : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [StringLength(Limit.NameMaxLength, MinimumLength = Limit.NameMinLength)]
        [Column] public string Name { get; set; }

        // Relation
        public IList<Address> Addresses { get; set; }
    }
}