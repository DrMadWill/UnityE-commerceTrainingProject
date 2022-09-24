using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Commons;
using UnityETP.Entity.Validations;

namespace UnityETP.Entity.Products
{
    /// <summary>
    /// Product Brands Table
    /// </summary>
    [Table("ProductBrands")]
    public class Brand : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [StringLength(Limit.NameMaxLength, MinimumLength = Limit.NameMinLength)]
        [Column] public string Name { get; set; }

        [Column] public string Image { get; set; }

        // Relation

        public Color Color { get; set; }
        public int ColorId { get; set; }

        public IList<Prodcut> Prodcuts { get; set; }
    }
}