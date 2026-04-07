using Microsoft.EntityFrameworkCore;
using StudentManagement.Repositories;
using StudentManagement.Models;
using StudentManagement.Data;
using StudentManagement.Services;


namespace StudentManagement.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext _context;
        private readonly ILogger<StudentService> _logger;
        public StudentRepository(StudentDbContext context, ILogger<StudentService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> GetStudentById(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        public async Task<Student> AddStudent(Student student)
        {
            try
            {
                _context.Students.Add(student);
                await _context.SaveChangesAsync();
                return student;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while adding student: {Name}, {Email}", student.Name, student.Email);
                throw;
            }

        }

        public async Task<Student> UpdateStudent(Student student)
        {
            _context.Students.Update(student);
            await _context.SaveChangesAsync();
            return student;
        }

        public async Task<bool> DeleteStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null) return false;

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return true;
        }
    }

}
