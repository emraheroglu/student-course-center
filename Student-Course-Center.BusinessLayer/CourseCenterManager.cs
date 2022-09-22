using Student_Course_Center.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Center.BusinessLayer
{
    public class CourseCenterManager
    {
        Repository<CourseCenterManager> courseCenterRepo = new Repository<CourseCenterManager>();

        public List<CourseCenterManager> GetAll()
        {
            return courseCenterRepo.List();
        }
    }
}
