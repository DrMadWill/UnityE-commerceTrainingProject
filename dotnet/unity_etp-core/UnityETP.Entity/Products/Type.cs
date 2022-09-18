using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Products
{
    /// <summary>
    /// Product Types Table
    /// </summary>
    [Table("ProductTypes")]
    public class Type : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [Column] public string Name { get; set; }

        public IList<Prodcut> Prodcuts { get; set; }
    }
}