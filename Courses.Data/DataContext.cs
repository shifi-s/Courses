
using Courses.Core.Entities;
using Courses.Core.Services;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Courses.Data
{
    public class DataContext:DbContext,IDataContext
    {
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=shifi-strul-courses-db");
        }

    }
}
