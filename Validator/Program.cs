using System.ComponentModel.DataAnnotations;

namespace Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new Data
            {
                AllowedValues = "X",
                Base64String = "ABC",
                Compare = "X",
                CreditCard = "X",
                CustomValidation = "xpto",
                CustomValidator = "abcd",
                EmailAddress = "https://www.google.com",
                EnumDataType = "mon",
                DeniedValues = "Y",
                FileExtensions = "foo.bar",
                Length = [ "2" ],
                MaxLength = "12345678901",
                MinLength = "1",
                Phone = "a",
                Range = 1,
                RegularExpression = "a",
                Required = "",
                StringLength = "ab",
                Url = "foo.bar",
                IsEven = 13.45
            };

            var results = new List<ValidationResult>();

            //var isValid = System.ComponentModel.DataAnnotations.Validator.TryValidateObject(data, new ValidationContext(data), results, validateAllProperties: true);

            var isValidProperty = System.ComponentModel.DataAnnotations.Validator.TryValidateProperty(data.IsEven, new ValidationContext(data) { MemberName = nameof(Data.IsEven) }, results);

        }
    }
}