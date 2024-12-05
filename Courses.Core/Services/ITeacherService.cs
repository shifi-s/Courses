using Courses.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Core.Services
{
    public interface ITeacherService
    {
        public List<Teacher> GetTeachers();
        public Teacher GetTeacher(int id);
    }
}
