﻿using System;
using System.Collections.Generic;

namespace SessionInNetCore.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string Password { get; set; } = null!;
    }
}
