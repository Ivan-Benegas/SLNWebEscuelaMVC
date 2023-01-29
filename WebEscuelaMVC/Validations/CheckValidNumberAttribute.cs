using System.ComponentModel.DataAnnotations;

namespace WebEscuelaMVC.Validations
{
    public class CheckValidNumberAttribute : ValidationAttribute
    {
        public CheckValidNumberAttribute()
        {
            ErrorMessage = "El número debe ser mayor a 100";
        }

        public override bool IsValid(object value)
        {
            int number = (int)value;

            if (number <= 100)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
