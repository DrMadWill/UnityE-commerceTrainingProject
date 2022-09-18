using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Orders;
using UnityETP.Entity.Products;

namespace UnityETP.Entity.Commons
{
    /// <summary>
    /// Color
    /// </summary>
    [Table("Colors")]
    public class Color : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [Column] public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 7, MinimumLength = 7)]
        [Column(TypeName = "char(7)")] public string Code { get; set; }
        // Relation 
        public IList<Orders.Status> OrderStatuses { get; set; }
        public IList<Organizations.Status> OrganizationStatuses { get; set; }
        public IList<Products.Status> ProductStatuses { get; set; }

        public IList<Icon> Icons { get; set; }
        public IList<Orders.Payments.Type> Types { get; set; }

        public IList<Brand> Brands { get; set; }
    }
}