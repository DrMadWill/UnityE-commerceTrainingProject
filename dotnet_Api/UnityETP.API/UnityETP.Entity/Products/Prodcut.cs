using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Products
{
    public class Prodcut : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [Column] public string Name { get; set; }

        [Column] public string Image { get; set; }
        [Column] public decimal CurrentPrice { get; set; }
        [Column] public decimal? OldPrice { get; set; }
        [Column(TypeName = "tinyint")] public byte Star { get; set; }
        [Column] public string MiniDescription { get; set; }
        [Column] public bool IsEnded { get; set; }

        public int ProductTypeId { get; set; }
        public int ProductBrandId { get; set; }
        public int ProductStatusId { get; set; }
        public int ProductVendorId { get; set; }
        public int ProductCategoryId { get; set; }
        public int ProductSubCategoryId { get; set; }
    }
}