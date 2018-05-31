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
            CoffeeEntities ORM = new CoffeeEntities();
            ViewBag.Items = ORM.Items.ToList();
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

        public ActionResult Submission(User data)
        {
            CoffeeEntities ORM = new CoffeeEntities();
            if (ModelState.IsValid)
            {
                try
                {
                    ORM.Users.Add(data);
                    ORM.SaveChanges();
                    ViewBag.message = $"All information has been added";
                }
                catch (Exception e)
                {
                    ViewBag.message = $"error! {e.Message}";

                    return View();
                }
            }
            else
            {
                ViewBag.message = $" User information is not valid, cannot add to DB";
            }

            return View();
        }
    }
}