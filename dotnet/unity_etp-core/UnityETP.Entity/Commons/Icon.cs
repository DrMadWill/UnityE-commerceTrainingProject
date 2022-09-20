using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Contacts;
using UnityETP.Entity.Validations;

namespace UnityETP.Entity.Commons
{
    /// <summary>
    /// Color
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

        [StringLength(Limit.IconLength)]
        [Column] public string Code { get; set; }
        // Relation 
       
        public Color Color { get; set; }
        public int ColorId { get; set; }
        public IList<OnlineAddress> OnlineAddresses { get; set; }
    }
}