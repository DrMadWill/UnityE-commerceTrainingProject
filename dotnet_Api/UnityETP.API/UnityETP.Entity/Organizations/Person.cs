using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Organizations
{
    public class Person : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [Column] public string FullName { get; set; }

        public int OrganizationId { get; set; }
        public int PostionId { get; set; }
        public int ContactId { get; set; }
    }
}