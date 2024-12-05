using Courses.Core.Entities;
using Courses.Core.Repositories;
using Courses.Core.Services;
using Courses.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Service
{
    public class CourseService:ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public List<Course> GetCourses()
        {
            return _courseRepository.getAllCourses();
        }

        public Course GetCourse(int id)
        {
            return _courseRepository.getCourseById(id);
        }

        public void DeleteCourse(int id)
        {
            _courseRepository.deleteCourseById(id);
        }


    }
}
