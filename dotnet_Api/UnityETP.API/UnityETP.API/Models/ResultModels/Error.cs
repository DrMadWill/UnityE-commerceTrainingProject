namespace UnityETP.API.Models.ResultModels
{
    public class Error
    {
        public int? Status { get; set; }
        public string? Message { get; set; }
        public DateTime? Time { get; set; }
    }
}
