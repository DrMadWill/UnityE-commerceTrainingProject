using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Options
{
    /// <summary>
    /// Option Items in Admin Panel Nav
    /// </summary>
    [Table("Items")]
    public class Item : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [Column] public string Name { get; set; }

        [Required]
        [Column] public string Controller { get; set; }

        [Required]
        [Column] public string Action { get; set; }
        [Column] public bool IsSafe { get; set; }

        // Relation
        public Option Option { get; set; }
        public int OptionId { get; set; }
    }
}