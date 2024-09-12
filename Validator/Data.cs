using System.ComponentModel.DataAnnotations;

namespace Validator
{
    [MetadataType(typeof(Data.Metadata))]
    public class Data : IValidatableObject
    {
        public class Metadata
        {
            [Required]
            public string? Required { get; set; }
        }
    
        //[Required]
        public string? Required { get; set; }

        //[MaxLength(10)]
        public required string MaxLength { get; set; }

        //[MinLength(5)]
        public required string MinLength { get; set; }

        //[AllowedValues("A", "B", "C")]
        public required string AllowedValues { get; set; }

        //[DeniedValues("X", "Y", "Z")]
        public required string DeniedValues { get; set; }

        //[StringLength(maximumLength: 10, MinimumLength = 5)]
        public required string StringLength { get; set; }

        //[RegularExpression(@"\d+")]
        public required string RegularExpression { get; set; }

        //[Range(5, 10, MinimumIsExclusive = false, MaximumIsExclusive = false)]
        public int Range { get; set; }

        //[Compare(nameof(Required))]
        public required string Compare { get; set; }

        //[EmailAddress]
        //@"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$"
        public required string EmailAddress { get; set; }

        //[Url]
        //http://, https://, ftp://
        public required string Url { get; set; }

        //[CreditCard]
        public required string CreditCard { get; set; }

        //[Phone]
        //@"^(\+\s?)?((?<!\+.*)\(\+?\d+([\s\-\.]?\d+)?\)|\d+)([\s\-\.]?(\(\d+([\s\-\.]?\d+)?\)|\d+))*(\s?(x|ext\.?)\s?\d+)?$"
        public required string Phone { get; set; }

        //[FileExtensions(Extensions = "jpg")]
        public required string FileExtensions { get; set; }

        //[EnumDataType(typeof(DayOfWeek))]
        public required string EnumDataType { get; set; }

        //[Length(5, 10)]
        public List<string> Length { get; set; } = new List<string>();

        //[CustomValidation(typeof(CustomValidator), nameof(Validator.CustomValidator.Validate))]
        public required string CustomValidation { get; set; }

        //[CustomValidator]
        public required string CustomValidator { get; set; }

        //[Base64String]
        public required string Base64String { get; set; }

        [IsEven]
        public double IsEven { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield return ValidationResult.Success!;
            yield return new ValidationResult("Error", new string[] { });
        }
    }
}
