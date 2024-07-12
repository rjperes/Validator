using System.ComponentModel.DataAnnotations;

namespace Validator
{
    public static class CustomValidator
    {
        public static ValidationResult Validate(object entity, ValidationContext context)
        {
            return ValidationResult.Success!;
        }

        public static bool IsEven(object entity)
        {
            return true;
        }
    }
}