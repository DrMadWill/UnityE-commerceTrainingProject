using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Contacts
{
    public class OnlineAddress
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column] public string Name { get; set; }

        [Column] public string Link { get; set; }
        public bool IsSecurity { get; set; }
        public int IconId { get; set; }
        public int? ContactId { get; set; }
    }
}