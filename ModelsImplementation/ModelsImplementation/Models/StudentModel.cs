using System.ComponentModel.DataAnnotations;

namespace ModelsImplementation.Models
{
    public class StudentModel
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; }
        public string email { get; set; }
        public int age { get; set; }
        public Gender gender { get; set; }
        public string isMarried { get; set; }
        public string description { get; set; }

        public StudentModel() { }

    }
    public enum Gender
    {
        MALE, FEMALE,
    }
}
