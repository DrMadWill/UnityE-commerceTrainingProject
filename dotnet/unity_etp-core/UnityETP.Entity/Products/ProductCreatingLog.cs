using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Users;

namespace UnityETP.Entity.Products
{
    /// <summary>
    ///  Product Creating Logs Table
    /// </summary>
    [Table("ProductCreatingLogs")]
    public class ProductCreatingLog : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        // Relation
        public Prodcut Prodcut { get; set; }

        public int ProductId { get; set; }

        public AppUser User { get; set; }
        public int UserId { get; set; }
    }
}