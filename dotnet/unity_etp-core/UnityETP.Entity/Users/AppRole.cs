using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Users
{
    /// <summary>
    /// Application Roles Table 
    /// </summary>
    public class AppRole : IdentityRole, IBaseEntity<string>
    {
        [Column] public DateTime CreateAt { get; set; } = DateTime.Now;
        [Column] public DateTime? UpdateAt { get; set; }
        [Column] public bool IsBlock { get; set; } = false;
        [Column] public bool IsDelete { get; set; } = false;

        // Relation
        public IList<Authorization> Authorizations { get; set; }
    }
}