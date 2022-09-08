using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Contacts
{
    public class Address : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Column] public int CountryId { get; set; }
        [Column] public int CityId { get; set; }
        [Column] public int RegionId { get; set; }
        public string LocaltionURL { get; set; }
        public string PostalCode { get; set; }
    }
}