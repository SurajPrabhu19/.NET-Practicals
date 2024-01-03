
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityCoreFrameworkImplementation.Models
{
    public class StudentModel
    {
        [Key]
        public int id { get; set; }
        [Column("studentname", TypeName = "varchar(100)")]
        public string name { get; set; }
        [Column("studentname", TypeName = "varchar(100)")]
        public int age { get; set; }    
        public string gender { get; set; }
    }
}
