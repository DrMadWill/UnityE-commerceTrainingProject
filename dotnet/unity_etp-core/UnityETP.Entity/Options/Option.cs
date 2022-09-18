using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Users;

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

        [Column] public string Name { get; set; }

        [Required]
        [Column] public string Controller { get; set; }

        [Required]
        [Column] public string Action { get; set; }
        // Relation
        public IList<Item> Items { get; set; }

        public IList<Authorization> Authorizations { get; set; }
    }
}