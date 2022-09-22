using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Center.EntityLayer.Entities
{
    public class CourseCenter
    {
        [Key]
        public int CenterID { get; set; }
        public string CenterName { get; set; }
        public string CenterAdress { get; set; }
        public string CenterPhoneNumber { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
