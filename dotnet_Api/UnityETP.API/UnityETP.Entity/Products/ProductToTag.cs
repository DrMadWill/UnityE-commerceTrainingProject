using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Products
{
    /// <summary>
    /// Product To Tag Table
    /// </summary>
    [Table("ProductToTags")]
    public class ProductToTag : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        // Relation
        public Prodcut Product { get; set; }

        public int ProductId { get; set; }

        public Tag ProductTag { get; set; }
        public int ProductTagId { get; set; }
    }
}