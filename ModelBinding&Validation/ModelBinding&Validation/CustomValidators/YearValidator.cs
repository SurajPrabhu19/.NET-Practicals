using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace ModelBinding_Validation.CustomValidators
{
    public class YearValidator : ValidationAttribute
    {
        public YearValidator() { }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime date = Convert.ToDateTime(value);
                if (date.Year >= 2000)
                    return new ValidationResult("Year should be less then 2000");
                else
                    return ValidationResult.Success;
            }
            return new ValidationResult("Year cannot be null, please re-enter value less than year 2000");

        }
    }
}
