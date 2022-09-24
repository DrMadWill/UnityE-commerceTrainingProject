using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Validations
{
    [NotMapped]
    public class Limit
    {
        public const int ImageMaxLength = 200;

        public const int NameMaxLength = 200;
        public const int NameMinLength = 3;

        public const int StarRangeMaxLength = 5;
        public const int StarRangeMinLength = 1;

        public const int TitleMaxLength = 5000;
        public const int TitleMinLength = 3;

        public const int MinLenght = 3;

        public const int ColorCodeLength = 7;
        public const int IconLength = 50;
        public const int LinkLength = 250;

        public const int EmailMaxLength = 320;
        public const int EmailMinLength = 5;

        public const int PostalCodeMaxLength = 30;
        public const int FaksLength = 30;
        public const int PhoneLength = 15;


        public const int ControllerMaxLength = 30;
        public const int ControllerMinLength = 2;

        public const int ActionMaxLength = 70;
        public const int ActionMinLength = 3;

        public const int IBANLength = 3;
    }
}
