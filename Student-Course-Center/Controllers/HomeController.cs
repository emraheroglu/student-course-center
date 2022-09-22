using Student_Course_Center.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_Course_Center.Controllers
{
    public class HomeController : Controller
    {
        private CourseManager _cM;

        public HomeController(CourseManager cM)
        {
            _cM = cM;
        }


        public ActionResult Index()
        {
            ViewBag.Message = "Your index page.";
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Courses()
        {
            var courses = _cM.GetAll2();

            return View(courses);
        }


    }
}