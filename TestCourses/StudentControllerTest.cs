﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Controllers;

namespace TestCourses
{
    public class StudentsControllerTest
    {
        [Fact]
        public void GetStudentById_ReturnsOk()
        {
            var controller = new StudentController();
            var result = controller.GetStudentById(1);
            Assert.IsType<OkObjectResult>(result);
        }

    }
}