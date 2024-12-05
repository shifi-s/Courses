using Courses.Core.Entities;
using Courses.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Data.Repositories
{
    public class StudentRepository:IStudentRepository
    {
        private readonly IDataContext _context;
        public StudentRepository(IDataContext context)
        {
            _context = context;
        }

        public List<Student> GetStudents()
        {
            return _context.students;
        }

        public void DeleteStudent(Student s)
        {
            _context.students.Remove(s);
        }

        public Student GetStudent(int id)
        {
            return _context.students.Find(s => s.Id == id);
        }

        public void updateAge(Student s,double age)
        {
            s.Age = age;
        }
        public void updateAdress(Student s, string adress)
        {
            s.Address = adress;
        }

    }
}
