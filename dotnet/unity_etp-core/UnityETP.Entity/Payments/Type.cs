using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Commons;

namespace UnityETP.Entity.Payments
{
    /// <summary>
    /// Payment Type
    /// </summary>
    [Table("PaymentTypes")]
    public class Type : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Column] public string Name { get; set; }
        [Column] public string Icon { get; set; }
        // Relation
        public Color Color { get; set; }
        public int ColorId { get; set; }
        public IList<Payment> Payments { get; set; }
    }
}