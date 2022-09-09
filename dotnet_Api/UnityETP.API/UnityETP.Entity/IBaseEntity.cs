namespace UnityETP.Entity
{
    public interface IBaseEntity<TPrimary>
    {
        public TPrimary Id { get; set; }

        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public bool IsDelete { get; set; }
    }
}