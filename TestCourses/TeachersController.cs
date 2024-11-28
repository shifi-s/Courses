using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Api.Controllers;

namespace TestCourses
{
    public class TeachersController
    {
        [Fact]

        public void GetTeacherById_ReturnsOk()
        {
            var controller = new TeacherController();
            var result = controller.GetTeacherById(1);
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
