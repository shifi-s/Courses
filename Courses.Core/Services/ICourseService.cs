using Courses.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Core.Services
{
    public interface ICourseService
    {
        public List<Course> GetCourses();
        public Course GetCourse(int id);

        public void DeleteCourse(int id);   
    }
}
