using System.ComponentModel.DataAnnotations;

namespace ModelBindingAndValidation.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage = "We believe in having a name to a person")]
        [StringLength(15, MinimumLength = 5, ErrorMessage ="Name must be between 3 to 15 chars")]
        public string name { get; set; }

        [Required(ErrorMessage = "Please create a email address for login purpose")]
        [EmailAddress]  //  Better use Regular Expression instead of [EmailAddress]
        public string email { get; set; }

        [Required(ErrorMessage = "Please add your age")]
        [Range(minimum: 10, maximum: 150, ErrorMessage = "We would like to hire mortal humans")]
        public int age { get; set; }
    }
}
