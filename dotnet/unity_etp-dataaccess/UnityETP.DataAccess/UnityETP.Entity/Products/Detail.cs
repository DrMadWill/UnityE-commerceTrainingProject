using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Validations;

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
        [MinLength(Limit.MinLenght)]
        [Column(TypeName = Validations.Type.Text)] public string DescriptionFull { get; set; }
        [MinLength(Limit.MinLenght)]
        [Column(TypeName = Validations.Type.Text)] public string Additionalinfo { get; set; }

        // Relation
        public Prodcut Prodcut { get; set; }
    }
}