
using Courses.Core.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Courses.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly DataContext _context;

        public StudentController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllStudents")]
        public IEnumerable<Student> GetAllStudents()
        {
            return _context.students;
        }

        [HttpGet("GetStudentById")]
        public ActionResult GetStudentById(int id)
        {
            var s = _context.students.Find(s => s.Id == id);
            if (s == null)
                return NotFound();
            return Ok(s);
        }

        [HttpPost("AddStudent")]
        public void AddStudent(Student s)
        {
            _context.students.Add(s);
        }

        [HttpPut("update/updateName")]
        public ActionResult updateName(int id, string name)
        {
            var s = _context.students.Find(s => s.Id == id);
            if (s == null)
                return NotFound();
            s.Name = name;
            return Ok();
        }

        [HttpPut("update/updatePhone")]
        public ActionResult updatePhone(int id, string phone)
        {
            var s = _context.students.Find(s => s.Id == id);
            if (s == null)
                return NotFound();
            s.Phone = phone;
            return Ok();
        }

        [HttpPut("update/updateAdress")]
        public ActionResult updateAdress(int id, string adress)
        {
            var s = _context.students.Find(s => s.Id == id);
            if (s == null)
                return NotFound();
            s.Address = adress;
            return Ok();
        }

        [HttpPut("update/updateAge")]
        public ActionResult updateAge(int id, double age)
        {
            var s = _context.students.Find(s => s.Id == id);
            if (s == null)
                return NotFound();
            s.Age = age;
            return Ok();
        }

        [HttpDelete("DeleteStudent")]
        public ActionResult DeleteStudent(int id)
        {
            var s = _context.students.Find(s => s.Id == id);
            if (s == null)
                return NotFound();
            _context.students.Remove(s);
            return Ok();
        }
    }
}
