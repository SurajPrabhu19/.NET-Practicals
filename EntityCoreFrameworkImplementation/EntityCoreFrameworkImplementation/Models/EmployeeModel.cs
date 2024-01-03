using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EntityCoreFrameworkImplementation.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }

        [Column("EmpName", TypeName = "varchar(100)")]
        public string Name { get; set; }

        [Column("EmpEmail", TypeName = "varchar(100)")]
        public string Email { get; set; }

        public int EmployeeId { get; set; }
    }
}
