using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Blogs
{
    /// <summary>
    /// Blog Detail  Table
    /// </summary>

    [Table("BlogDetail")]
    public class Detail : BaseEntity<int>
    {
        [Key,ForeignKey("Blogs")]
        [Column]
        public override int Id { get; set; }

        [Required]
        [Column(TypeName = "ntext")] public string Description { get; set; }
        // Relation 
        public Blog Blog { get; set; }
    }
}