using Student_Course_Center.DataAccessLayer;
using Student_Course_Center.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Center.BusinessLayer
{
    public class StudentManager
    {
        Repository<Student> studentRepo = new Repository<Student>();

        public List<Student> GetAll()
        {
            return studentRepo.List();
        }

    }
}
