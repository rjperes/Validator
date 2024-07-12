using System.ComponentModel.DataAnnotations;

namespace Validator
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class IsEvenAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Value is null", new string[] { validationContext.MemberName! });
            }

            if (this.IsValid(value))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult($"Value {value} is not even", new string[] { validationContext.MemberName! });
        }

        public override bool IsValid(object? value)
        {
            if (value == null)
            {
                return false;
            }

            if (IsNumber(value?.GetType()!))
            {
                var number = (int)Convert.ChangeType(value, TypeCode.Int32)!;
                if ((number % 2) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsNumber(Type? type)
        {
            if (type == null)
            {
                return false;
            }

            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Byte:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.SByte:
                case TypeCode.Single:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                    return true;
                case TypeCode.Object:
                    if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        return IsNumber(Nullable.GetUnderlyingType(type)!);
                    }
                    return false;
            }

            return false;
        }
    }
}
