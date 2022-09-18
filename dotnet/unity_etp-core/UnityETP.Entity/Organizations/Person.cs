using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Contacts;

namespace UnityETP.Entity.Organizations
{
    /// <summary>
    /// People Type
    /// </summary>
    [Table("OrganizationPeople")]
    public class Person : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [Column] public string FullName { get; set; }
        
        // Relation
        public Organization Organization { get; set; }
        public int OrganizationId { get; set; }

        public Position Position { get; set; }
        public int PostionId { get; set; }

        public Contact Contact { get; set; }
        public int ContactId { get; set; }
    }
}