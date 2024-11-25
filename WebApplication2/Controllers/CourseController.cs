using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        static List<Course> courses = new List<Course> { new Course { Id = 1, Name = "unb", Begin_Hour = new TimeOnly(), Day = 1, Minutes = 45, Students = new List<Student> { new Student { Id = 1, Name = "ttt", Address = "qqq", Age = 19.5, Phone = "055" }, new Student { Id = 2, Name = "hhhh", Address = "yyy", Age = 19, Phone = "054" }, new Student { Id = 3, Name = "ff", Address = "wwww", Age = 18.4, Phone = "053" } }, Teacher = new Teacher { Id = 1, Name = "oo", Address = "eaw", Email = "mnmn", Phone = "052" } } };
        
        [HttpGet("GetAllCourses")]
        public IEnumerable<Course> GetAllCourses()
        {
            return courses;
        }

        [HttpGet("GetCourseById")]
        public ActionResult GetCourseById(int id)
        {
           var c= courses.Find(c=>c.Id==id);
            if(c==null)
                return NotFound();  
            return Ok(c);
        }

        [HttpPut("update/updateBeginHour")]
        public ActionResult updateCourse(int id, TimeOnly begin)
        {
            var c = courses.Find(c => c.Id == id);
            if(c==null)
                return NotFound();
            c.Begin_Hour= begin;    
            return Ok();
        }
       
        [HttpPut("update/updateDay")]
        public ActionResult updateDay(int id, int day)
        {
            var c = courses.Find(c => c.Id == id);
            if(c==null)
                return NotFound();
            c.Day = day;
            return Ok();
        }

        [HttpPut("update/changeTeacher")]
        public ActionResult deleteStudentFromCourse(int idOfCourse, int idOfTeacher, Teacher t)
        {
            var c = courses.Find(c => c.Id == idOfCourse);
            if(c==null)
                return NotFound();
            c.Teacher = t;
            return Ok();
        }

        [HttpPost("AddCourse")]
        public void AddCourse([FromBody] Course course)
        {

            courses.Add(course);

        }

        [HttpPost("studentsList/AddStudentToCourse")]
        public ActionResult AddStudentToCourse(int idOfCourse, Student s)
        {
            var c = courses.Find(c => c.Id == idOfCourse);
            if(c==null)
                return NotFound();
            c.Students.Add(s);
            return Ok();    
        }

        [HttpPost("studentsList/deleteStudentFromCourse")]
        public ActionResult deleteStudentFromCourse(int idOfCourse,int idOfStudent)
        {
            var c = courses.Find(c => c.Id == idOfCourse);
            if(c==null)
                return NotFound("course not found");
           var s= c.Students.Find(s=>s.Id==idOfStudent);
            if (s==null)    
                return NotFound("student not found");
            c.Students.Remove(s);
            return Ok();    
        }

        [HttpDelete("DeleteCourse")]
        public ActionResult DeleteCourse(int id)
        {
          var c= courses.Find(c => c.Id == id);
            if(c==null)
                return NotFound();  
            courses.Remove(c);  
            return Ok();

        }

    }
}
