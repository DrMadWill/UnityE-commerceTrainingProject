using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Contacts;
using UnityETP.Entity.Options;
using UnityETP.Entity.Validations;

namespace UnityETP.Entity.Commons
{
    /// <summary>
    /// Icons
    /// </summary>
    [Table("Icons")]
    public class Icon : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [StringLength(Limit.NameMaxLength, MinimumLength = Limit.NameMinLength)]
        [Column] public string Name { get; set; }

        [StringLength(Limit.IconLength, MinimumLength = Limit.IconLength)]
        [Column(TypeName = Validations.Type.Char)] public string Code { get; set; }

        // Relation

        public IList<OnlineAddress> OnlineAddresses { get; set; }
        public IList<Shippings.Status> ShippStatus { get; set; }
        public IList<Option> Options { get; set; }
    }
}