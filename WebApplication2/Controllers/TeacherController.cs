using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        static List<Teacher> teachers=new List<Teacher>();
        // GET: api/<TeacherController>
        [HttpGet]
        public IEnumerable<Teacher> Get()
        {
            return teachers;
        }

        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        public Teacher Get(int id)
        {
            return teachers.Find(t=>t.Id==id);
        }

        // POST api/<TeacherController>
        [HttpPost]
        public void Post([FromBody] Teacher teacher)
        {
            teachers.Add(teacher);  
        }

        // PUT api/<TeacherController>/5
        [HttpPut("{id}")]
        public void Put(int id, string name="",string address = "",string phone = "",string email="")
        {
            if (name != "")
                teachers.Find(t => t.Id == id).Name = name;
            if (address != "")
                teachers.Find(t => t.Id == id).Address = address;
            if (phone != "")
                teachers.Find(t => t.Id == id).Phone = phone;
            if (email != "")
                teachers.Find(t => t.Id == id).Email = email;
        }

        // DELETE api/<TeacherController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            teachers.Remove(teachers.Find(t=> t.Id==id));
        }
    }
}
