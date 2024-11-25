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
        [HttpGet("GetAllTeachers")]
        public IEnumerable<Teacher> GetAllTeachers()
        {
            return teachers;
        }

        // GET api/<TeacherController>/5
        [HttpGet("GetTeacherById/{id}")]
        public ActionResult GetTeacherById(int id)
        {
           var t=teachers.Find(t=>t.Id==id);
            if(t==null) 
                return NotFound();  
            return Ok(t);
        }

        // POST api/<TeacherController>
        [HttpPost("AddTeacher")]
        public void AddTeacher([FromBody] Teacher teacher)
        {
            teachers.Add(teacher);  
        }

        // PUT api/<TeacherController>/5
        [HttpPut("update/updateName")]
        public void updateName(int id, string name)
        {
            teachers.Find(t => t.Id == id).Name = name;
        }
        [HttpPut("update/updatePhone")]
        public void updatePhone(int id, string phone)
        {
            teachers.Find(t => t.Id == id).Phone = phone;
        }

        [HttpPut("update/updateAdress")]
        public void updateAdress(int id, string adress)
        {
            teachers.Find(t => t.Id == id).Address = adress;
        }

        [HttpPut("update/updateEmail")]
        public void updateEmail(int id, string email)
        {
            teachers.Find(t => t.Id == id).Email = email;
        }

        // DELETE api/<TeacherController>/5
        [HttpDelete("deleteTeacher/{id}")]
        public void deleteTeacher(int id)
        {
            teachers.Remove(teachers.Find(t=> t.Id==id));
        }
    }
}
