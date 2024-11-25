using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        static List<Student> students = new List<Student> { new Student { Id = 1, Name = "r", Address = "c", Age = 19.5, Phone = "055" }, new Student { Id = 2, Name = "e", Address = "c", Age = 19.5, Phone = "055" } };    
        
        [HttpGet("GetAllStudents")]
        public IEnumerable<Student> GetAllStudents()
        {
            return students;
        }

        [HttpGet("GetStudentById")]
        public ActionResult GetStudentById(int id)
        {
           var s=students.Find(s=>s.Id==id);
            if(s == null)
                return NotFound();  
            return Ok(s);
        }

        [HttpPost("AddStudent")]
        public void AddStudent(Student s)
        {
            students.Add(s);
        }

        [HttpPut("update/updateName")]
        public ActionResult updateName(int id,string name)
        {
            var s = students.Find(s => s.Id == id);
            if(s == null)
                return NotFound();
            s.Name = name;
            return Ok();
        }

        [HttpPut("update/updatePhone")]
        public ActionResult updatePhone(int id, string phone)
        {
            var s = students.Find(s => s.Id == id);
            if (s == null)
                return NotFound();
            s.Phone = phone;
            return Ok();
        }

        [HttpPut("update/updateAdress")]
        public ActionResult updateAdress(int id, string adress)
        {
            var s = students.Find(s => s.Id == id);
            if (s == null)
                return NotFound();
            s.Address = adress;
            return Ok();
        }

        [HttpPut("update/updateAge")]
        public ActionResult updateAge(int id, double age)
        {
            var s = students.Find(s => s.Id == id);
            if (s == null)
                return NotFound();
            s.Age = age;
            return Ok();
        }

        [HttpDelete("DeleteStudent")]
        public ActionResult DeleteStudent(int id)
        {
            var s = students.Find(s => s.Id == id);
            if (s == null)
                return NotFound();
            students.Remove(s);
            return Ok();
        }
    }
}
