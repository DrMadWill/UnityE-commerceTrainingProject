namespace UnityETP.Entity
{
    public class BaseEntity<TPrimary> : Modfiy, IBaseEntity<TPrimary>
    {
        public virtual TPrimary Id { get; set; }
    }
}