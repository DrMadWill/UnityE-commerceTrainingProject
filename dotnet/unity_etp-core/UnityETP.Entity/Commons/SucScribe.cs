using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Validations;

namespace UnityETP.Entity.Commons
{
    /// <summary>
    /// SucScribes For Not Registered.
    /// </summary>
    [Table("SucScribes")]
    public class SucScribe : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [StringLength(Limit.EmailMaxLength, MinimumLength = Limit.EmailMinLength)]
        [RegularExpression(RegEx.Email, ErrorMessage = "Email format not valid.")]
        [Column] public string Email { get; set; }
    }
}