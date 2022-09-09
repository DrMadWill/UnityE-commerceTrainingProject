using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Products
{
    public class Detail : BaseEntity<int>
    {
        public override int Id { get; set; }
        [Column] public string DescriptionFull { get; set; }
        [Column] public string Additionalinfo { get; set; }
    }
}