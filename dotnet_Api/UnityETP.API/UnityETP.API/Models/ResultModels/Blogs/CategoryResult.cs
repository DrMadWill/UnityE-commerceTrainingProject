namespace UnityETP.API.Models.ResultModels.Blogs
{
    public class CategoryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public bool IsDelete { get; set; }
    }
}
