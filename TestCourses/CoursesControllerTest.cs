using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Api.Controllers;
using Courses.Api;
using Courses.Data;
using Courses.Data.Repositories;

namespace TestCourses
{
    public class TestCourseController
    {
        FakeContext _context = new FakeContext();

        [Fact]
        public void GetCourseById_ReturnsOk()
        {
            var controller = new CourseRepository(_context);
            var result = controller.getCourseById(1);
            Assert.IsType<OkObjectResult>(result);

        }
    }
}
