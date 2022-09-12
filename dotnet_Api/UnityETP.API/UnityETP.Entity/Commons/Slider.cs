using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Column] public string Link { get; set; }
        [Column] public string Title { get; set; }
        [Column] public string Image { get; set; }
    }
}