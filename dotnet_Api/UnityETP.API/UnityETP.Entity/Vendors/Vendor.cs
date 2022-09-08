using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityETP.Entity.Vendors
{
    public class Vendor : BaseEntity<int>
    {
        public override int Id { get; set; }
        
        [Column] public DateTime? OrganizationCreated { get; set; }
        [Column] public byte Star { get; set; }

        public int ColorId { get; set; }
    }
}
