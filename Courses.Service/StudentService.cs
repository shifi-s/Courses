using Courses.Core.Entities;
using Courses.Core.Repositories;
using Courses.Core.Services;
using Courses.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Service
{
    public class StudentService:IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public List<Student> GetStudents()
        {
            return _studentRepository.GetStudents();    
        }

        public Student GetStudent(int id) {
            return _studentRepository.GetStudent(id);
        }

        public void DeleteStudent(Student s)
        {
            _studentRepository.DeleteStudent(s);    
        }
        public void updateAge(Student s, double age)
        {
            _studentRepository.updateAge(s, age);
        }
        public void updateAdress(Student s,string adress)
        {
            _studentRepository.updateAdress(s, adress);
        }
    }
}
