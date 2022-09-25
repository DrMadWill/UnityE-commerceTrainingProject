using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Validations;

namespace UnityETP.Entity.Commons
{
    /// <summary>
    /// Slider In Index
    /// </summary>
    [Table("Sliders")]
    public class Slider : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        [Required]
        [StringLength(Limit.LinkLength)]
        [Column] public string Link { get; set; }
        [StringLength(Limit.TitleMaxLength,MinimumLength =Limit.MinLenght)]
        [Column] public string Title { get; set; }

        [StringLength(Limit.ImageMaxLength)]
        [Column] public string Image { get; set; }
    }
}