using System.ComponentModel.DataAnnotations;

namespace DEMO1.Validations
{
    public class AllowSizeFile : ValidationAttribute
    {
        private readonly int _maxSizeFile;
        public AllowSizeFile(int maxSizeFile) {
            _maxSizeFile = maxSizeFile;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if ( file != null) 
            {
                if (file.Length > _maxSizeFile)
                {
                    return new ValidationResult(GetMessgeError());
                }
            }
            return ValidationResult.Success;
        }
        private string GetMessgeError()
        {
            return $"Maximum a allowed file size is {_maxSizeFile} bytes";
        }
    }
}
