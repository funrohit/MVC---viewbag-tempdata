using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppFirst.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            Mymodel obj = new Mymodel();
            obj.name = "Rohit Singh";
            obj.age = 22;
            obj.email = "xolo2rohit@gmail.com";

            return View(obj);
        }

        public ActionResult Contact()
        {
            ViewBag.a1 = "Hllow";
            ViewBag.a2 = 12345;
            ViewBag.a3 = 4368.5f;
            ViewBag.a4 = DateTime.Now;
            ViewBag.list = new List<string>()
            {
                "Allahabad",
                "Noida",
                "Lucknow",
            };

            ViewData["b1"] = "data from view bag";
            ViewData["b2"] = 32560;
            ViewData["b3"] = 588.4f;
            ViewData["b4"] = DateTime.Now;
            ViewData["list2"] = new List<string>()
            {
                "UK",
                "USA",
                "Unani",
            };

            TempData["c1"] = "This is Tempdata";
            TempData["c2"] = 123;
            TempData["c3"] = 53.4f;
            TempData["c4"] = DateTime.Now;

            

            return View();
        }
    }
}