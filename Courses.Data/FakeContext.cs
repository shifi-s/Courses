
using Courses.Core.Entities;
using Courses.Data;

namespace Courses.Api
{
    public class FakeContext : IDataContext
    {
        public List<Teacher> teachers { get; set; }
        public List<Student> students { get; set; }
        public List<Course> courses { get; set; }

    }
}
