using ModelsImplementation.Models;

namespace ModelsImplementation.Repositories.Contracts
{
    public interface IStudentRepository
    {
        List<StudentModel> getAllStudents();
        StudentModel getStudentById(int id);
        StudentModel getStudentByEmail(string email);
    }
}
