using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace ModelBinding_Validation.CustomValidators
{
    public class YearValidator : ValidationAttribute
    {
        private int MinYear;
        private int MaxYear;
        private string defaultErrorMsg = "Date is not in range {0} to {1}";
        public YearValidator() { }
        public YearValidator(int minYear = 1985, int maxYear = 2005)
        {
            MinYear = minYear;
            MaxYear = maxYear;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime date = Convert.ToDateTime(value);
                if (date.Year > MaxYear || date.Year < MinYear)
                {
                    //return new ValidationResult(ErrorMessage + $" year range - {MinYear} to {MaxYear}");\i
                    //if (string.IsNullOrEmpty(ErrorMessage))
                    //    ErrorMessage = $"Date is not in range {MinYear} to {MaxYear}";
                    return new ValidationResult(string.Format(ErrorMessage ?? defaultErrorMsg, MinYear, MaxYear));
                }
                //return new ValidationResult("Year should be in range 1985 to 1999");
                else
                    return ValidationResult.Success;
            }
            return null; // new ValidationResult("Year cannot be null, please re-enter value less than year 2000");

        }
    }
}
