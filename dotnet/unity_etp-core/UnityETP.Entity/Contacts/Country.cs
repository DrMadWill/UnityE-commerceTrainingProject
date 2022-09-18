using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Contacts
{
    /// <summary>
    /// Address => Country 
    /// </summary>
    [Table("Countries")]
    public class Country : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [Column] public string Name { get; set; }
        // Relation 
        public IList<Address> Addresses { get; set; }
    }
}