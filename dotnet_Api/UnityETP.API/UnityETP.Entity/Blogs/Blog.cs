using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Blogs
{
    public class Blog : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [Column] public string Title { get; set; }

        [Column] public string Image { get; set; }

        [Column] public string PreviewDescrption { get; set; }

        public int CategoryId { get; set; }
        public string UserId { get; set; }
    }
}