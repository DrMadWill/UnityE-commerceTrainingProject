using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Options;

namespace UnityETP.Entity.Users
{
    /// <summary>
    /// Authorizations Table
    /// </summary>
    [Table("UserAuthorizations")]
    public class Authorization
    {
        public AppRole AppRole { get; set; }
        public string AppRoleId { get; set; }

        public Option Option { get; set; }
        public int OptionId { get; set; }
        public bool IsSafe { get; set; }
    }
}