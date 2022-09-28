using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Validations;
using UnityETP.Entity.Vendors;

namespace UnityETP.Entity.Products
{
    /// <summary>
    /// Products Table
    /// </summary>
    [Table("Products")]
    public class Prodcut : BaseEntity<int>
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

        [Column] public decimal CurrentPrice { get; set; }
        [Column] public decimal? OldPrice { get; set; }

        [Range(1, 5)]
        [Column] public float Star { get; set; }

        [MinLength(Limit.MinLenght)]
        [Column] public string MiniDescription { get; set; }

        [Column] public bool IsEnded { get; set; }

        // Relation
        public Detail Detail { get; set; }

        public Type ProductTypes { get; set; }
        public int ProductTypeId { get; set; }

        public Brand ProductBrand { get; set; }
        public int ProductBrandId { get; set; }

        public Status ProductStatus { get; set; }
        public int ProductStatusId { get; set; }

        public Vendor ProductVendor { get; set; }
        public int? ProductVendorId { get; set; }

        public Category ProductCategory { get; set; }
        public int ProductCategoryId { get; set; }

        public SubCategory ProductSubCategory { get; set; }
        public int? ProductSubCategoryId { get; set; }

        public IList<ProductToTag> ProductToTags { get; set; }
        public IList<Image> Images { get; set; }
        public IList<Review> Reviews { get; set; }
        public IList<ProductCreatingLog> ProductCreatingLogs { get; set; }
        public IList<Stock> ProductSize { get; set; }
    }
}