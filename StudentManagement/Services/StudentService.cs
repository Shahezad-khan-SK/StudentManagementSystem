using StudentManagement.Repositories;
using StudentManagement.Services;
using StudentManagement.Models;

namespace StudentManagement.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return await _studentRepository.GetAllStudents();
        }

        public async Task<Student> GetStudentById(int id)
        {
            return await _studentRepository.GetStudentById(id);
        }

        public async Task<Student> AddStudent(Student student)
        {
            student.CreatedDate = DateTime.Now;
            return await _studentRepository.AddStudent(student);
        }

        public async Task<Student> UpdateStudent(int id, Student student)
        {
            var existingStudent = await _studentRepository.GetStudentById(id);
            if (existingStudent == null) return null;

            existingStudent.Name = student.Name;
            existingStudent.Email = student.Email;
            existingStudent.Age = student.Age;
            existingStudent.Course = student.Course;

            return await _studentRepository.UpdateStudent(existingStudent);
        }

        public async Task<bool> DeleteStudent(int id)
        {
            return await _studentRepository.DeleteStudent(id);
        }
    }


}
