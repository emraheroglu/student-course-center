using Student_Course_Center.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Center.DataAccessLayer
{
    public class Context: DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseCenter> CourseCenters { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
