using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Users;

namespace UnityETP.Entity.Products
{
    /// <summary>
    /// Product Review Table
    /// </summary>
    [Table("ProductReviews")]
    public class Review : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Column] public byte Star { get; set; }
        [Column] public string Content { get; set; }

        // Relations
        public Prodcut Prodcut { get; set; }
        public int ProductId { get; set; }

        public AppUser User { get; set; }
        public string UserId { get; set; }
    }
}