using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Commons;

namespace UnityETP.Entity.Users
{
    /// <summary>
    ///  User Statuses Table
    /// </summary>
    [Table("UserStatuses")]
    public class Status : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        [Required]
        [Column] public string Name { get; set; }

        // Relation
        public Color Color { get; set; }
        public int ColorId { get; set; }
        public IList<AppUser> AppUsers { get; set; }
    }
}