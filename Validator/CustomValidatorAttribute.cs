using System.ComponentModel.DataAnnotations;

namespace Validator
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Struct | AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class CustomValidatorAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            return ValidationResult.Success;
        }

        public override bool IsValid(object? value)
        {
            return true;
        }
    }
}
