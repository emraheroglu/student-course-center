using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Student_Course_Center.DataAccessLayer.DapperManager
{
    public  class DapperManager
    {
        public  string _connectionString = "Server=EMRAHEROGLU\\MSSQLSERVER2019;Database=StudentCourseCenter;Trusted_Connection=true";

        public  object dapperConnection(string _connectionString)
        { 
            var sC = new SqlConnection(_connectionString); ;

            sC.Open();

            return sC;
        }

    }
}
