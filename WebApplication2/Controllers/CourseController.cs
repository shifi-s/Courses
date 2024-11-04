using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        static List<Course> courses = new List<Course> { new Course { Id = 1, Name = "unb", Begin_Hour = new TimeOnly(), Day = 1, Minutes = 45, Students = new  List<Student> { new Student { Id = 1, Name = "ttt", Address = "qqq", Age = 19.5, Phone = "055" }, new Student { Id = 2, Name = "hhhh", Address = "yyy", Age = 19, Phone = "054" }, new Student { Id = 3, Name = "ff", Address = "wwww", Age = 18.4, Phone = "053" } }, Teacher = new Teacher { Id = 1, Name = "oo", Address = "eaw", Email = "mnmn", Phone = "052" } } };
        // GET: api/<CourseController>
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return courses;
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public Course Get(int id)
        {
            return courses.Find(c=>c.Id==id);
        }

        // POST api/<CourseController>
        [HttpPost]
        public void Post([FromBody] Course course)
        {
             
            courses.Add(course);
        
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        
        public void Put(int id,TimeOnly begin=new TimeOnly(), int minutes=0,string name="", int day = 0)
        {
            if (minutes > 0)
                courses.Find(c => c.Id == id).Minutes = minutes;
           if(name!="")
                courses.Find(c => c.Id == id).Name = name;
           if(day>0)
                courses.Find(c => c.Id == id).Day = day;
           if (!begin.Equals(new TimeOnly()))
                courses.Find(c => c.Id == id).Begin_Hour = begin;

        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           courses.Remove(courses.Find(c => c.Id == id));   

        }



    }
}
