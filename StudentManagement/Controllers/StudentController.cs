using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using StudentManagement.Services;

namespace StudentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudents() =>
            Ok(await _studentService.GetAllStudents());

        [HttpPost]
        public async Task<IActionResult> AddStudent(Student student) =>
            Ok(await _studentService.AddStudent(student));

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(int id, Student student) =>
            Ok(await _studentService.UpdateStudent(id, student));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id) =>
            Ok(await _studentService.DeleteStudent(id));
    }
}
