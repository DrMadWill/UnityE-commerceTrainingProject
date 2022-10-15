using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Validations;

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
        [StringLength(Limit.NameMaxLength, MinimumLength = Limit.NameMinLength)]
        [Column] public string Name { get; set; }

        [Required]
        [StringLength(Limit.ControllerMaxLength, MinimumLength = Limit.ControllerMinLength)]
        [Column] public string Controller { get; set; }

        [Required]
        [StringLength(Limit.ActionMaxLength, MinimumLength = Limit.ActionMinLength)]
        [Column] public string Action { get; set; }

        [Column] public bool IsSafe { get; set; }

        // Relation
        public Option Option { get; set; }

        public int OptionId { get; set; }
    }
}