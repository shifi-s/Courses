using System.ComponentModel.DataAnnotations.Schema;

namespace Courses.Core.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Student> Students = new List<Student>();

        public Teacher Teacher { get; set; }

        public int Day { get; set; }

        [NotMapped]
        public TimeOnly Begin_Hour { get; set; }
        public int Minutes { get; set; }


    }
}
