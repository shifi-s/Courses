using Courses.Core.Entities;
using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Courses.Api.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly DataContext _context;

        public TeacherController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllTeachers")]
        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _context.teachers;
        }

        [HttpGet("GetTeacherById/{id}")]
        public ActionResult GetTeacherById(int id)
        {
            var t = _context.teachers.Find(t => t.Id == id);
            if (t == null)
                return NotFound();
            return Ok(t);
        }

        [HttpPost("AddTeacher")]
        public void AddTeacher([FromBody] Teacher teacher)
        {
            _context.teachers.Add(teacher);
        }

        [HttpPut("update/updateName")]
        public ActionResult updateName(int id, string name)
        {
            var t = _context.teachers.Find(t => t.Id == id);
            if (t == null) { return NotFound(); }
            t.Name = name;
            return Ok();
        }

        [HttpPut("update/updatePhone")]
        public ActionResult updatePhone(int id, string phone)
        {
            var t = _context.teachers.Find(t => t.Id == id);
            if (t == null) { return NotFound(); };
            t.Phone = phone;
            return Ok();
        }

        [HttpPut("update/updateAdress")]
        public ActionResult updateAdress(int id, string adress)
        {
            var t = _context.teachers.Find(t => t.Id == id);
            if (t == null)
                return NotFound();
            t.Address = adress;
            return Ok();

        }

        [HttpPut("update/updateEmail")]
        public ActionResult updateEmail(int id, string email)
        {
            var t = _context.teachers.Find(t => t.Id == id);
            if (t == null) { return NotFound(); }
            t.Email = email;
            return Ok();
        }

        [HttpDelete("deleteTeacher/{id}")]
        public ActionResult deleteTeacher(int id)
        {
            var t = _context.teachers.Find(t => t.Id == id);
            if (t == null)
                return NotFound();
            _context.teachers.Remove(t);
            return Ok();
        }
    }
}
