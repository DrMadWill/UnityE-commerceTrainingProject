using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Commons;
using UnityETP.Entity.Users;
using UnityETP.Entity.Validations;

namespace UnityETP.Entity.Options
{
    /// <summary>
    /// Option in Admin Panel Nav
    /// </summary>
    [Table("Options")]
    public class Option : BaseEntity<int>
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
        // Relation

        public Icon Icon { get; set; }
        public int IconId { get; set; }

        public IList<Item> Items { get; set; }
        public IList<Authorization> Authorizations { get; set; }
    }
}