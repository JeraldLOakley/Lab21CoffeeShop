using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab21.Models;

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
            Registration regForm = new Registration();
            ViewBag.RegForm = regForm; 
            return View();
        }

        public ActionResult Submission(Registration r)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Registration = r;
                return View();
            }
            else
            {
                return View("Registration");
            }
        }





    }

}