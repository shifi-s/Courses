using Courses.Core.Entities;
using Courses.Core.Repositories;
using Courses.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Service
{
    public class TeacherService:ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository= teacherRepository;  
        }
        public List<Teacher> GetTeachers()
        {
            return _teacherRepository.GetAllTeachers();
        }

        public Teacher GetTeacher(int id)
        {
            return _teacherRepository.GetTeacherById(id);
        }


    }
}
