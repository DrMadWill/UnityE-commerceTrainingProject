using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Users;

namespace UnityETP.Entity.Blogs
{
    public class Comment : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        [Required]
        [MinLength(3)]
        [Column] public string Description { get; set; }
        [Column] public bool IsBlocked { get; set; }
        [Column] public bool IsHasChild { get; set; }

        // Relation 
        public Blog Blog { get; set; }
        public int BlogId { get; set; }
        public Comment ParentComment { get; set; }
        public int ParentCommentId { get; set; }
        public AppUser User { get; set; }
        public string UserId { get; set; }
    }
}