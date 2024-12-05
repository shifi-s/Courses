using Courses.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Courses.Core.Repositories
{
    public interface ITeacherRepository
    {
        public List<Teacher> GetAllTeachers();
        public Teacher GetTeacherById(int id);
    }
}
