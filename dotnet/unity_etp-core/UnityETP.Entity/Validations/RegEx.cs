using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Validations
{
    [NotMapped]
    public class RegEx
    {
        public const string Email = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
    }
}