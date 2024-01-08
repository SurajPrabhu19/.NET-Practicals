using System;
using System.Collections.Generic;

namespace SessionInNetCore.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Name { get; set; }
    }
}
