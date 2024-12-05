
using Courses.Core.Entities;
using Courses.Data;
using Microsoft.EntityFrameworkCore;

namespace Courses.Api
{
    public class FakeContext : IDataContext
    {
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }

    }
}
