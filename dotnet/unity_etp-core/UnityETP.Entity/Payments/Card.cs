using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Validations;

namespace UnityETP.Entity.Payments
{
    /// <summary>
    /// Payment Card
    /// </summary>
    [Table("PaymentCards")]
    public class Card : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [StringLength(Limit.IBANLength, MinimumLength = Limit.IBANLength)]
        [Column(TypeName = Validations.Type.Char)] public int IBAN { get; set; }

        [Column(TypeName = Validations.Type.Byte)] public byte Month { get; set; }
        [Column(TypeName = Validations.Type.SInt)] public int Year { get; set; }
        public IList<Payment> Payments { get; set; }
    }
}