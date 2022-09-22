using Student_Course_Center.DataAccessLayer.Abstract;
using Student_Course_Center.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using Student_Course_Center.EntityLayer.DapperEntities;

namespace Student_Course_Center.DataAccessLayer
{
    public class CourseRepository 
    {

        public string _connectionString = "Server=EMRAHEROGLU\\MSSQLSERVER2019;Database=StudentCourseCenter;Trusted_Connection=true";

        SqlConnection _sc;


        public CourseRepository(SqlConnection sc)
        {
            sc = _sc;
        }

        public List<Courses> getAll()
        {

            _sc.Open();
            var courses = _sc.Query("select * from Courses");

            return (List<Courses>)courses;
        }

        public Course getById(int id)
        {
            
        }
    }
}
