using Courses.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Core.Repositories
{
    public interface IStudentRepository
    {
        public List<Student> GetStudents();

        public Student GetStudent(int id);
        public void DeleteStudent(Student s);

        public void updateAge(Student s, double age);

        public void updateAdress(Student s, string adress); 
    }
}
