using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Orders
{
    /// <summary>
    /// Shippings 
    /// </summary>
    [Table("OrderShippings")]
    public class Shipping : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Column] public DateTime? ArriveDate { get; set; }

        [Column] public DateTime? StartDate { get; set; }

        public int OrganizationId { get; set; }

        [NotMapped]
        public bool IsEnd { get => ArriveDate != null; }
        // Relation
        public IList<Detail> OrderDetails { get; set; }
    }
}