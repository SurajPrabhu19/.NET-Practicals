﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using ModelBinding_Validation.CustomValidators;

namespace ModelBinding_Validation.Models
{
    public class Employee
    {
        public int id { get; set; }

        [Required(ErrorMessage = "We prefer having a {0} for an Employee")]
        [Display(Name ="Employee Name")]    // will be taken by {0} in the Error Message
        [NotNull]
        //[StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "Employee Name should be between 2 to 50 characters")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "{0} should be between {2} to {1} characters")]
        public string? name { get; set; }
        [Required(ErrorMessage = "Requesting you to enter the email details")]
        [EmailAddress(ErrorMessage = " Please enter a valid email address")]
        public string? email { get; set; }
        public bool? isLoggedIn { get; set; }

        [Phone(ErrorMessage = "Please enter a valid {0}")]
        [StringLength(10, ErrorMessage = "Please enter a {1} digit {0}")]
        public string? phoneNo { get; set; }
        public string? password { get; set; }
        [Compare(otherProperty: "password", ErrorMessage = "Password doesnt match, please re-enter your password")]
        public string? confirmPassword { get; set; }
        [Range(20000, 99999.99, ErrorMessage = "{0} can be between {1} to {2}")] // Only works with Numbers like int, double, etc
        public double? salary { get; set; }

        [YearValidator(minYear:1990, maxYear:2000)]
        public DateTime? dob { get; set; }
        public override string ToString()
        {
            return $"Employee Name: {name}\n Email:{email}\n Phone:{phoneNo } ";
        }
    }

}
