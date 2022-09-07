using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Blogs
{
    public class Comment : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Column] public string Description { get; set; }

        [Column] public bool IsBlocked { get; set; }
        [Column] public bool IsHasChild { get; set; }

        public int BlogId { get; set; }
        public int ParentCommentId { get; set; }
        public string UserId { get; set; }
    }
}