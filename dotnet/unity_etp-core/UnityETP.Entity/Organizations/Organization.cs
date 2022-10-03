using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Contacts;
using UnityETP.Entity.Shippings;
using UnityETP.Entity.Validations;

namespace UnityETP.Entity.Organizations
{
    /// <summary>
    /// Organization Type
    /// </summary>
    [Table("Organizations")]
    public class Organization : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [StringLength(Limit.NameMaxLength, MinimumLength = Limit.NameMinLength)]
        [Column] public string Name { get; set; }

        [Column(TypeName = Validations.Type.Text)] public string Description { get; set; }
        [Column] public string HotTel { get; set; }

        [StringLength(Limit.ImageMaxLength)]
        [Column] public string Image { get; set; }

        // Relation

        public Status Status { get; set; }
        public int StatusId { get; set; }

        public Contact Contact { get; set; }
        public int ContactId { get; set; }

        public IList<Person> People { get; set; }

        public IList<Shipping> Shippings { get; set; }
    }
}