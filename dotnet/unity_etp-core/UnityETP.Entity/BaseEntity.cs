using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity
{
    [NotMapped]
    public class BaseEntity<TPrimary> : Modfiy, IBaseEntity<TPrimary>
    {
        public virtual TPrimary Id { get; set; }
    }
}