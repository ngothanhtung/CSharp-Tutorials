using EntityFrameworkQuizLibrary;
using Microsoft.AspNetCore.Mvc;

namespace QuizApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {

        [HttpGet]
        public IActionResult GetStudents()
        {
            using var context = new QuizContext();
            var students = context.Students.ToList();
            return Ok(students);
        }

        // POST: Create a student
        [HttpPost]
        public IActionResult CreateStudent([FromBody] Student student)
        {
            using var context = new QuizContext();

            context.Students.Add(student);

            context.SaveChanges();
            // Logic to create a student would go here
            return Ok(new { Message = "Student created successfully", Student = student });
        }

        // PUT: Update a student
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, [FromBody] Student updatedStudent)
        {
            using var context = new QuizContext();
            var student = context.Students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound(new { Message = "Student not found" });
            }
            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;
            student.Email = updatedStudent.Email;
            context.SaveChanges();
            // Logic to update a student would go here
            return Ok(new { Message = "Student updated successfully", Student = student });
        }

        [HttpDelete("{id}")]
        public IActionResult UpdateStudent(int id)
        {
            using var context = new QuizContext();
            var student = context.Students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound(new { Message = "Student not found" });
            }

            context.Students.Remove(student);
            context.SaveChanges();
            // Logic to update a student would go here
            return Ok(new { Message = "Student deleted successfully", Student = student });
        }
    }
}
