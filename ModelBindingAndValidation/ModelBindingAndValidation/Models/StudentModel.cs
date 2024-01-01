using System.ComponentModel.DataAnnotations;

namespace ModelBindingAndValidation.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage = "We believe in having a name to a person")]
        [MinLength(2)]
        public string name { get; set; }
    }
}
