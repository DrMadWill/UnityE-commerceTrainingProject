using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Contacts
{
    /// <summary>
    /// Location and Address Information
    /// </summary>
    [Table("Addresses")]
    public class Address : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        [Column] public string LocaltionURL { get; set; }
        [Column] public string PostalCode { get; set; }

        // Relation 
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public Region Region { get; set; }
        public int RegionId { get; set; }

        public IList<Contact> Contacts { get; set; }
    }
}