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
        // GET: api/<CourseController>
        [HttpGet("GetAllCourses")]
        public IEnumerable<Course> GetAllCourses()
        {
            return courses;
        }

        // GET api/<CourseController>/5
        [HttpGet("GetCourseById")]
        public ActionResult GetCourseById(int id)
        {
           var c= courses.Find(c=>c.Id==id);
            if(c==null)
                return NotFound();  
            return Ok(c);
        }


        // PUT api/<CourseController>/5
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

        public void updateDay(int id, int day)
        {
            courses.Find(c => c.Id == id).Day = day;
        }
        [HttpPut("update/changeTeacher")]
        public void deleteStudentFromCourse(int idOfCourse, int idOfTeacher, Teacher t)
        {
            courses.Find(c => c.Id == idOfCourse).Teacher = t;
        }

        [HttpPost("AddCourse")]
        public void AddCourse([FromBody] Course course)
        {

            courses.Add(course);

        }
        [HttpPost("studentsList/AddStudentToCourse")]
        public void AddStudentToCourse(int idOfCourse, Student s)
        {
            courses.Find(c => c.Id == idOfCourse).Students.Add(s);
        }

        [HttpPost("studentsList/deleteStudentFromCourse")]
        public void deleteStudentFromCourse(int idOfCourse,int idOfStudent)
        {
            courses.Find(c => c.Id == idOfCourse).Students.Remove(courses.Find(c => c.Id == idOfCourse).Students.Find(s=>s.Id==idOfStudent));
        }

      
        // DELETE api/<CourseController>/5
        [HttpDelete("DeleteCourse")]
        public void DeleteCourse(int id)
        {
           courses.Remove(courses.Find(c => c.Id == id));   

        }

    }
}
