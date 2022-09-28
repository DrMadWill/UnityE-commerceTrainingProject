using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Validations
{
    [NotMapped]
    public class Type
    {
        public const string Text = "ntext";
        public const string Byte = "tinyint";
        public const string Char = "nchar";
        public const string SInt = "smallint";
    }
}