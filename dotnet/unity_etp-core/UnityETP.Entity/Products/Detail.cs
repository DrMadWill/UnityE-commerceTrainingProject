using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Products
{
    /// <summary>
    /// Product Detail Table
    /// </summary>
    [Table("ProductDetails")]
    public class Detail : BaseEntity<int>
    {
        [Key, ForeignKey("Products")]
        public override int Id { get; set; }

        [Column] public string DescriptionFull { get; set; }
        [Column] public string Additionalinfo { get; set; }

        // Relation
        public Prodcut Prodcut { get; set; }
    }
}