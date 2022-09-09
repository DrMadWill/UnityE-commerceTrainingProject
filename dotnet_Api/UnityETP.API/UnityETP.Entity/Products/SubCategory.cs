using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Products
{
    public class SubCategory : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [Column] public string Name { get; set; }

        [Column] public string Image { get; set; }
        public int CategoryId { get; set; }
    }
}