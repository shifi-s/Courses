using Courses.Core.Entities;
using Courses.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Data.Repositories
{
    public class CourseRepository:ICourseRepository
    {
        private readonly IDataContext _context;
        public CourseRepository(IDataContext context)
        {
            _context = context;
        }

        public List<Course> getAllCourses()
        {
            return _context.courses;   
        }

        public Course getCourseById(int id)
        {
            return _context.courses.Find(c => c.Id == id); 
        }
        public void deleteCourseById(int id)
        {
            _context.courses.Remove(_context.courses.Find(c=>c.Id == id));  
        }
    }
}
