using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Contacts
{
    /// <summary>
    /// Contact Info  
    /// </summary>
    [Table("Cities")]
    public class Contact : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Column] public string Faks { get; set; }
        // Relation 
        public Address Address { get; set; }
        public int AddressId { get; set; }

    }
}