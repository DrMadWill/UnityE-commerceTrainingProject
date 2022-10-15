using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Validations;

namespace UnityETP.Entity.Products
{
    /// <summary>
    /// Product SubCategories Table
    /// </summary>
    [Table("ProductSubCategories")]
    public class SubCategory : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [StringLength(Limit.NameMaxLength, MinimumLength = Limit.NameMinLength)]
        [Column] public string Name { get; set; }

        [StringLength(Limit.ImageMaxLength)]
        [Column] public string Image { get; set; }

        // Relation
        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public IList<Prodcut> Prodcuts { get; set; }
    }
}