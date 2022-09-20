using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Validations;

namespace UnityETP.Entity.Contacts
{
    /// <summary>
    /// Phone Contact Info 
    /// </summary>
    [Table("Phones")]
    public class Phone : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        [Required]
        [StringLength(Limit.NameMaxLength, MinimumLength = Limit.NameMinLength)]
        [Column] public string Name { get; set; }
        [Required]
        [Column] public string Number { get; set; }
        // Relation 
        public Contact Contact { get; set; }
        public int ContactId { get; set; }
    }
}