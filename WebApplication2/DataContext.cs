using WebApplication2;

namespace Courses
{
    public class DataContext
    {
        public List<Teacher> teachers = new List<Teacher>();
        public List<Student> students = new List<Student> { new Student { Id = 1, Name = "r", Address = "c", Age = 19.5, Phone = "055" }, new Student { Id = 2, Name = "e", Address = "c", Age = 19.5, Phone = "055" } };
        public List<Course> courses = new List<Course> { new Course { Id = 1, Name = "unb", Begin_Hour = new TimeOnly(), Day = 1, Minutes = 45, Students = new List<Student> { new Student { Id = 1, Name = "ttt", Address = "qqq", Age = 19.5, Phone = "055" }, new Student { Id = 2, Name = "hhhh", Address = "yyy", Age = 19, Phone = "054" }, new Student { Id = 3, Name = "ff", Address = "wwww", Age = 18.4, Phone = "053" } }, Teacher = new Teacher { Id = 1, Name = "oo", Address = "eaw", Email = "mnmn", Phone = "052" } } };

    }
}
