using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Orders;
using UnityETP.Entity.Organizations;

namespace UnityETP.Entity.Contacts
{
    /// <summary>
    /// Contact Info  
    /// </summary>
    [Table("Contacts")]
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
        public IList<OnlineAddress> OnlineAddresses { get; set; }
        public IList<Detail> OrderDetails { get; set; }
        public IList<Organization> Organizations { get; set; }
        public IList<Person> People { get; set; }
    }
}