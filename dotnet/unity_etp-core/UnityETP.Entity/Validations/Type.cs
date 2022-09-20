using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityETP.Entity.Validations
{
    [NotMapped]
    public class Type
    {
        public const string Text = "ntext";
        public const string Byte = "tinyint";
        public const string Char = "char";
    }
}
