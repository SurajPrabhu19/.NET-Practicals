﻿using System;
using System.Collections.Generic;

namespace DBFirst_EntityFramework.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Phone { get; set; }
    }
}
