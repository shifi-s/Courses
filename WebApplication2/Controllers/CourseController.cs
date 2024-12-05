using Courses.Core.Entities;
using Courses.Core.Services;
using Courses.Data;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Courses.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("GetAllCourses")]
        public IEnumerable<Course> GetAllCourses()
        {
            return _courseService.GetCourses();
        }


        [HttpGet("GetCourseById")]
        public ActionResult GetCourseById(int id)
        {
            var c = _courseService.GetCourse(id);
            if (c == null)
                return NotFound();
            return Ok(c);
        }

        //        [HttpPut("update/updateBeginHour")]
        //        public ActionResult updateCourse(int id, TimeOnly begin)
        //        {
        //            var c = _context.courses.Find(c => c.Id == id);
        //            if (c == null)
        //                return NotFound();
        //            c.Begin_Hour = begin;
        //            return Ok();
        //        }

        //        [HttpPut("update/updateDay")]
        //        public ActionResult updateDay(int id, int day)
        //        {
        //            var c = _context.courses.Find(c => c.Id == id);
        //            if (c == null)
        //                return NotFound();
        //            c.Day = day;
        //            return Ok();
        //        }

        //        [HttpPut("update/changeTeacher")]
        //        public ActionResult deleteStudentFromCourse(int idOfCourse, int idOfTeacher, Teacher t)
        //        {
        //            var c = _context.courses.Find(c => c.Id == idOfCourse);
        //            if (c == null)
        //                return NotFound();
        //            c.Teacher = t;
        //            return Ok();
        //        }

        //        [HttpPost("AddCourse")]
        //        public void AddCourse([FromBody] Course course)
        //        {

        //            _context.courses.Add(course);

        //        }

        //        [HttpPost("studentsList/AddStudentToCourse")]
        //        public ActionResult AddStudentToCourse(int idOfCourse, Student s)
        //        {
        //            var c = _context.courses.Find(c => c.Id == idOfCourse);
        //            if (c == null)
        //                return NotFound();
        //            c.Students.Add(s);
        //            return Ok();
        //        }

        //        [HttpPost("studentsList/deleteStudentFromCourse")]
        //        public ActionResult deleteStudentFromCourse(int idOfCourse, int idOfStudent)
        //        {
        //            var c = _context.courses.Find(c => c.Id == idOfCourse);
        //            if (c == null)
        //                return NotFound("course not found");
        //            var s = c.Students.Find(s => s.Id == idOfStudent);
        //            if (s == null)
        //                return NotFound("student not found");
        //            c.Students.Remove(s);
        //            return Ok();
        //        }

        [HttpDelete("DeleteCourse")]
        public ActionResult DeleteCourse(int id)
        {
            var c = _courseService.GetCourse(id);
            if (c == null)
                return NotFound("course not found");
            _courseService.DeleteCourse(id);
            return Ok();

        }

    }
}
