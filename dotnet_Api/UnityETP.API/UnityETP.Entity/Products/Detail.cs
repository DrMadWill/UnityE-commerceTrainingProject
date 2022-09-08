using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityETP.Entity.Products
{
    public class Detail : BaseEntity<int>
    {
        public override int Id { get; set; }
        [Column] public string DescriptionFull { get; set; }
        [Column] public string Additionalinfo { get; set; }
    }
}
