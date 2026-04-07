using StudentManagement.Models;

namespace StudentManagement.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudents();
        Task<Student> GetStudentById(int id);
        Task<Student> AddStudent(Student student);
        Task<Student> UpdateStudent(int id, Student student);
        Task<bool> DeleteStudent(int id);
    }
}
