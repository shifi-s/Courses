using Courses.Api.Controllers;
using Courses.Api;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Data;
using Courses.Data.Repositories;

namespace TestCourses
{
    public class StudentsControllerTest
    {
        FakeContext _context = new FakeContext();
        [Fact]
        public void GetStudentById_ReturnsOk()
        {
            var controller = new StudentRepository(_context);
            var result = controller.GetStudentsById(1);
            Assert.IsType<OkObjectResult>(result);
        }

    }
}
