using Courses.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Data
{
    public interface IDataContext
    {
        List<Teacher> teachers { get; set; }
        List<Student> students { get; set; }
        List<Course> courses { get; set; }
    }
}
