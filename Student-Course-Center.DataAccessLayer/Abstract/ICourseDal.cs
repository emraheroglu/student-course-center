using Student_Course_Center.EntityLayer.DapperEntities;
using Student_Course_Center.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Center.DataAccessLayer.Abstract
{
    public interface ICourseDal/*:IRepository<Course>*/
    {
        List<Courses> getAll();

        Courses getById(int id);
    }
}
