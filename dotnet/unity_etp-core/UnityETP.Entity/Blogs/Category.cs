using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Validations;

namespace UnityETP.Entity.Blogs
{
    /// <summary>
    /// Blog To Tag Connection Table
    /// Protect Constraint Key ( Dot add Same BlogId : TagId )
    /// </summary>
    [Table("BlogCategories")]
    public class Category : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [StringLength(Limit.NameMaxLength, MinimumLength = Limit.NameMinLength)]
        [Column] public string Name { get; set; }

        public IList<Blog> Blogs { get; set; }
    }
}