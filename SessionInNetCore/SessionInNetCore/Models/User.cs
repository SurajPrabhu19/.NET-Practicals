using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SessionInNetCore.Models
{
    public partial class User
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; } = null!;
        public string? Name { get; set; }
        public string? Phone { get; set; }
        [Required]
        [DataType(DataType.Password)] 
        public string Password { get; set; } = null!;
    }
}
