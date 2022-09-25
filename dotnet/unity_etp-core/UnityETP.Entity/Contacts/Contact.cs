using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Orders;
using UnityETP.Entity.Organizations;
using UnityETP.Entity.Validations;

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

        [StringLength(Limit.FaksLength)]
        [Column] public string Faks { get; set; }
        // Relation 
        public Address Address { get; set; }
        public int AddressId { get; set; }
        public IList<OnlineAddress> OnlineAddresses { get; set; }
        public IList<Orders.Detail> UserOrderDetails { get; set; }
        public IList<Vendors.Orders.Detail> VendorOrderDetails { get; set; }
        public IList<Organization> Organizations { get; set; }
        public IList<Person> People { get; set; }
    }
}