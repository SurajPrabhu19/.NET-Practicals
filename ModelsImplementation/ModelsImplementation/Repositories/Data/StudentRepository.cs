using Microsoft.AspNetCore.Mvc;
using ModelsImplementation.Controllers;
using ModelsImplementation.Models;
using System.Diagnostics;
using ModelsImplementation.Repositories.Contracts;

namespace ModelsImplementation.Repositories.Data
{

    public class StudentRepository : IStudentRepository
    {

        
        public List<StudentModel> getAllStudents()
        {
            //throw new NotImplementedException();
            return dataSource();
        }

        public StudentModel getStudentByEmail(string email)
        {
            //throw new NotImplementedException();
            return dataSource().FirstOrDefault(x => x.email.Equals(email));
        }

        public StudentModel getStudentById(int id)
        {
            //throw new NotImplementedException();
            return dataSource().FirstOrDefault(x => x.id == id);
        }

        public static List<StudentModel> dataSource()
        {
            List<StudentModel> students = new List<StudentModel>() {
                new StudentModel{id=1, age=23, name="suraj", email="s@gmail.com"},
                new StudentModel{id=2, age=23, name="prabhu", email="p@gmail.com"},
                new StudentModel{id=3, age=24, name="nitya", email="s@gmail.com"},
            };

            return students;
        }
    }
}
