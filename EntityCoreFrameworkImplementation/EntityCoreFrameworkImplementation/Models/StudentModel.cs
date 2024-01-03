
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
        public string gender { get; set; }

        public int age { get; set; }
    }
}
