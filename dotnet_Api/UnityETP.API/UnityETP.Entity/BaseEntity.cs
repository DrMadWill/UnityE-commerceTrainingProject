namespace UnityETP.Entity
{
    public class BaseEntity<TPrimary> : Modfiy
    {
        public virtual TPrimary Id { get; set; }
    }
}