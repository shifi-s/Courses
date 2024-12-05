
using Courses.Core.Entities;
using Courses.Core.Services;

namespace Courses.Data
{
    public class DataContext:IDataContext
    {
        public List<Teacher> teachers { get; set; }
        public List<Student> students { get; set; }
        public List<Course> courses { get; set; }

        public DataContext() 
        {
            teachers= new List<Teacher>();  
            students= new List<Student>();
            courses= new List<Course>();
            teachers.Add(new Teacher { Id = 0, Name = "shifi", Address = "yona", Email = "@", Phone = "054" });
            students.Add(new Student { Id = 0, Name = "r", Age = 19, Address = "tt", Phone = "055" });
            courses.Add(new Course { Id = 0, Name = "s", Begin_Hour = new TimeOnly(), Day = 1, Minutes = 45, Teacher = new Teacher(), Students = new List<Student>() });

        }

    }
}
