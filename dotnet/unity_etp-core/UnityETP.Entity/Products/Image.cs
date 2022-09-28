using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Validations;

namespace UnityETP.Entity.Products
{
    /// <summary>
    /// Product Images Table
    /// </summary>
    [Table("ProductImages")]
    public class Image : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [StringLength(Limit.NameMaxLength, MinimumLength = Limit.NameMinLength)]
        [Column] public string Name { get; set; }

        [StringLength(Limit.ImageMaxLength)]
        [Column] public string Source { get; set; }

        // Relation
        public Prodcut Prodcut { get; set; }

        public int ProductId { get; set; }
    }
}