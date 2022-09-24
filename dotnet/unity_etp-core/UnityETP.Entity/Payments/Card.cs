using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Payments
{
    /// <summary>
    /// Payment Card
    /// </summary>
    [Table("PaymentCard")]
    public class Card : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Column] public int IBAN { get; set; }
        public byte Month { get; set; }
        public int Year { get; set; }
        public IList<Payment> Payments { get; set; }
    }
}