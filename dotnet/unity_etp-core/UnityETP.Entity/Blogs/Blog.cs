using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Users;
using UnityETP.Entity.Validations;

namespace UnityETP.Entity.Blogs
{
    /// <summary>
    /// Blogs Data
    /// </summary>
    [Table("Blogs")]
    public class Blog : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [StringLength(Limit.TitleMaxLength, MinimumLength = Limit.TitleMinLength)]
        [Column] public string Title { get; set; }

        [StringLength(Limit.ImageMaxLength)]
        [Column] public string Image { get; set; }

        [Column] public string PreviewDescrption { get; set; }

        // Relation

        public Detail Detail { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public AppUser User { get; set; }
        public string UserId { get; set; }

        public IList<BlogToTag> BlogToTags { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}