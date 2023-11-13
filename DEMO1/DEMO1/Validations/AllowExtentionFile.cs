using System.ComponentModel.DataAnnotations;

namespace DEMO1.Validations
{
    public class AllowExtentionFIle : ValidationAttribute
    {
        private readonly string[] _extentions;
        public AllowExtentionFIle(string[] extentions)
        {
            _extentions = extentions;
        }
        protected override ValidationResult IsValid( 
            object value, ValidationContext validationContext)
        {
           var file = value as IFormFile;
            if (file != null) 
            {
                var extensions = Path.GetExtension(file.FileName);
                if (!_extentions.Contains(extensions.ToLower()))
                {
                    return new ValidationResult(GetErrorMessage());
                }
            }
            // Return success if file is null or has a valid extension
            return ValidationResult.Success;
        }

        private String GetErrorMessage()
        {
            return "this is not an image";
        }
    }
}