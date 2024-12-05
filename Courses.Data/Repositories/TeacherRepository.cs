using Courses.Core.Entities;
using Courses.Core.Repositories;
using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Courses.Data.Repositories
{
    public class TeacherRepository:ITeacherRepository
    {
        private readonly IDataContext _context;
        public TeacherRepository(IDataContext context)
        {
            _context = context;
        }

        public List<Teacher> GetAllTeachers()
        {
            return _context.teachers;
        }

        public Teacher GetTeacherById(int id)
        {
            return _context.teachers.Find(t => t.Id == id);
        }
    }
}
