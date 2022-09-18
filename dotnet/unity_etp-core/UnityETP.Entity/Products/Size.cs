using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Products
{
    /// <summary>
    /// Product Sizes Table
    /// </summary>
    [Table("ProductSizes")]
    public class Size : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Column] public float Calibre { get; set; }
    }
}