using Courses.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Data
{
    public interface IDataContext
    {
        DbSet<Teacher> teachers { get; set; }
        DbSet<Student> students { get; set; }
        DbSet<Course> courses { get; set; }
    }
}
