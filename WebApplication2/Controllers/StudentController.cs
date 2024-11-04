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
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return students;
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return students.Find(s=>s.Id==id);
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post(Student s)
        {
            students.Add(s);
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id,string name=" ",string adress=" ",int age=-1,string phone=" ")
        {
            if (name!=" ")
             students.Find(s=>s.Id==id).Name=name;
            if (adress!=" ")
                students.Find(s => s.Id == id).Address =adress;
            if(age!=-1)
                students.Find(s => s.Id == id).Age = age;
            if(phone!=" ")
                students.Find(s => s.Id == id).Phone = phone;
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            students.Remove(students.Find(s => s.Id == id));
        }
    }
}
