using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Products
{
    public class Stock : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Column] public DateTime LifeTime { get; set; }
        [Column] public bool IsEnd { get; set; }
        [Column] public string SKU { get; set; }

        public int PorductId { get; set; }
        public int ProductSizeId { get; set; }
    }
}