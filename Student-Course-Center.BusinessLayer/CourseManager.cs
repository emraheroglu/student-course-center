using Student_Course_Center.DataAccessLayer;
using Student_Course_Center.EntityLayer.DapperEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Center.BusinessLayer
{
    public class CourseManager
    {
        Repository<CourseManager> courseRepo = new Repository<CourseManager>();

        public CourseRepository _cR;
        public CourseManager(CourseRepository cR)
        {
            _cR = cR;
        }
        public List<CourseManager> GetAll()
        {
            return courseRepo.List();
        }

        public List<Courses> GetAll2()
        {
            return _cR.getAll();
        }
    }
}
