using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Commons;
using UnityETP.Entity.Validations;

namespace UnityETP.Entity.Shippings
{
    /// <summary>
    /// Shipping Statuses Table
    /// </summary>
    [Table("ShippingStatuses")]
    public class Status : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [StringLength(Limit.NameMaxLength, MinimumLength = Limit.NameMinLength)]
        [Column] public string Name { get; set; }

        // Relation

        public Icon Icon { get; set; }
        public int IconId { get; set; }

        public Color Color { get; set; }
        public int ColorId { get; set; }

        public IList<Shipping> Shippings { get; set; }
    }
}