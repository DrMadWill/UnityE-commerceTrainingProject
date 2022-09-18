using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Organizations
{
    /// <summary>
    /// Positions Type
    /// </summary>
    [Table("OrganizationPositions")]
    public class Position : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [Column] public string Name { get; set; }

        public IList<Person> People { get; set; }
    }
}