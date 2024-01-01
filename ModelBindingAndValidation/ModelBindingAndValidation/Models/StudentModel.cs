using System.ComponentModel.DataAnnotations;

namespace ModelBindingAndValidation.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage = "We believe in having a name to a person")]
        //[MinLength(2)]
        //[MaxLength(8)]
        [StringLength(15, MinimumLength = 5, ErrorMessage ="Name must be between 3 to 15 chars")]
        public string name { get; set; }
    }
}
