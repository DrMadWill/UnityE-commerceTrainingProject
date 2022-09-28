using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Blogs
{
    /// <summary>
    /// Blog To Tag Connection Table
    /// Protect Constraint Key ( Dot add Same BlogId : TagId )
    /// </summary>
    [Table("BlogToTags")]
    public class BlogToTag : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        // Relation
        public int BlogId { get; set; }

        public Blog Blog { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}