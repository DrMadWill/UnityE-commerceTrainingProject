using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity
{
    [NotMapped]
    public class Modfiy
    {
        [Column] public DateTime CreateAt { get; set; } = DateTime.Now;
        [Column] public DateTime? UpdateAt { get; set; }
        [Column] public bool IsDelete { get; set; } = false;
    }
}