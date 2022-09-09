using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Commons
{
    public class Color : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [Column] public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 7, MinimumLength = 7)]
        [Column(TypeName = "char(7)")] public string Code { get; set; }
    }
}