using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Validations;

namespace UnityETP.Entity.Blogs
{
    /// <summary>
    /// Blog Detail  Table
    /// </summary>

    [Table("BlogDetail")]
    public class Detail : BaseEntity<int>
    {
        [Key, ForeignKey("Blogs")]
        [Column]
        public override int Id { get; set; }

        [Required]
        [MinLength(Limit.MinLenght)]
        [Column(TypeName = Validations.Type.Text)] public string Description { get; set; }

        // Relation
        public Blog Blog { get; set; }
    }
}