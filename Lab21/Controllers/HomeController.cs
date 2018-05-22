using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab21.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Submission(string fName, string lName, string email, long phone = 0)
        {
            ViewBag.RegFirstName = fName;
            ViewBag.RegLastName = lName;
            ViewBag.RegEmail = email;
            ViewBag.RegPhone = phone;
            return View();
        }





    }

}