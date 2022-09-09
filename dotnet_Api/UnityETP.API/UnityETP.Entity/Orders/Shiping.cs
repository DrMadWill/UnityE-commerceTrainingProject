using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityETP.Entity.Orders
{
    public class Shiping : BaseEntity<int>
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

    }
}
