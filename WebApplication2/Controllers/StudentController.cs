using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        static List<Student> students = new List<Student> { new Student { Id = 1, Name = "r", Address = "c", Age = 19.5, Phone = "055" }, new Student { Id = 2, Name = "e", Address = "c", Age = 19.5, Phone = "055" } };    
        // GET: api/<StudentController>
        [HttpGet("GetAllStudents")]
        public IEnumerable<Student> GetAllStudents()
        {
            return students;
        }

        // GET api/<StudentController>/5
        [HttpGet("GetStudentById")]
        public ActionResult GetStudentById(int id)
        {
           var s=students.Find(s=>s.Id==id);
            if(s == null)
                return NotFound();  
            return Ok(s);
        }

        // POST api/<StudentController>
        [HttpPost("AddStudent")]
        public void AddStudent(Student s)
        {
            students.Add(s);
        }

        // PUT api/<StudentController>/5
        [HttpPut("update/updateName")]
        public void updateName(int id,string name)
        {
            students.Find(s=>s.Id==id).Name = name;
        }
        [HttpPut("update/updatePhone")]
        public void updatePhone(int id, string phone)
        {
            students.Find(s => s.Id == id).Phone = phone;
        }

        [HttpPut("update/updateAdress")]
        public void updateAdress(int id, string adress)
        {
            students.Find(s => s.Id == id).Address = adress;
        }

        [HttpPut("update/updateAge")]
        public void updateAge(int id, double age)
        {
            students.Find(s => s.Id == id).Age = age;
        }
        // DELETE api/<StudentController>/5
        [HttpDelete("DeleteStudent")]
        public void DeleteStudent(int id)
        {
            students.Remove(students.Find(s => s.Id == id));
        }
    }
}
