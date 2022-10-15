using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Options;

namespace UnityETP.Entity.Users
{
    /// <summary>
    /// Authorizations Table
    /// </summary>
    [Table("UserAuthorizations")]
    public class Authorization:BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        public AppRole AppRole { get; set; }
        public string AppRoleId { get; set; }

        public Option Option { get; set; }
        public int OptionId { get; set; }
        public bool IsSafe { get; set; }
    }
}