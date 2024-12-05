using Courses.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Core.Repositories
{
    public interface ICourseRepository
    {
        public List<Course> getAllCourses();

        public Course getCourseById(int id);

        public void deleteCourseById(int id);
     
    }

}
