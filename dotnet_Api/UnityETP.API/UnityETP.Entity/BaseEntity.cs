namespace UnityETP.Entity
{
    public class BaseEntity<TPrimary>
    {
        public virtual TPrimary Id { get; set; }

        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime? UpdateAt { get; set; }
    }
}