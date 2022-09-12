using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Contacts
{
    /// <summary>
    /// Address => City 
    /// </summary>
    [Table("Cities")]
    public class City : BaseEntity<int>
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