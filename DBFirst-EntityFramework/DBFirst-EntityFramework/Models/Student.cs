using System;
using System.Collections.Generic;

namespace DBFirst_EntityFramework.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Dept { get; set; }
        public int RollNo { get; set; }
    }
}
