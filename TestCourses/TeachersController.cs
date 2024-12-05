using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Api.Controllers;
using Courses.Data;
using Courses.Api;
using Courses.Service;
using Courses.Data.Repositories;

namespace TestCourses
{
    public class TeachersController
    {
        FakeContext _context = new FakeContext();
        [Fact]

        
        public void GetTeacherById_ReturnsOk()
        {
            var controller = new TeacherRepository(_context);
            var result = controller.GetTeacherById(1);
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
