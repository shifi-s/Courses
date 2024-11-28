using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Api.Controllers;

namespace TestCourses
{
    public class TestCourseController
    {


        [Fact]
        public void GetCourseById_ReturnsOk()
        {
            var controller = new CourseController();
            var result = controller.GetCourseById(1);
            Assert.IsType<OkObjectResult>(result);

        }
    }
}
