using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Blogs
{
    /// <summary>
    /// Blog Tags Table 
    /// </summary>

    [Table("BlogTags")]
    public class Tag : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [Column] public string Name { get; set; }
        // Relation 
        public IList<BlogToTag> BlogToTags { get; set; }
    }
}