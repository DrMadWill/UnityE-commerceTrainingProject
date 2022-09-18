using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Commons;

namespace UnityETP.Entity.Contacts
{
    /// <summary>
    /// Online Contact Info  
    /// </summary>
    [Table("OnlineAddresses")]
    public class OnlineAddress : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        [Required]
        [Column] public string Name { get; set; }
        [Column] public string Link { get; set; }
        [Column] public bool IsSecurity { get; set; }

        // Relation 
        public Icon Icon { get; set; }
        public int IconId { get; set; }
        public Contact Contact { get; set; }
        public int ContactId { get; set; }
    }
}