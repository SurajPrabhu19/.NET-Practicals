﻿namespace ModelBinding_Validation.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? email { get; set; }
        public bool? isLoggedIn { get; set; }
        public string? phoneNo { get; set; }
        public string? password { get; set; }
        public string? confirmPassword { get; set; }

        public override string ToString()
        {
            return $"Employee Name: {name}\n Email:{email}\n Phone:{phoneNo } ";
        }
    }

}
