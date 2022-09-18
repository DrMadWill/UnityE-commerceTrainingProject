using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Products
{
    /// <summary>
    /// Product Categories Table
    /// </summary>
    [Table("ProductCategories")]
    public class Category : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [Column] public string Name { get; set; }

        [Column] public string Image { get; set; }
        public IList<Prodcut> Prodcuts { get; set; }
        public IList<Category> Categories { get; set; }
    }
}