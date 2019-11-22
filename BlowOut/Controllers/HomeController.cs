using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//GROUP 2-1
//KEARA HUTCHINSON, DAVID KNIGHT, NATHAN HANSEN, HAYLEY MYERS
//THIS PROGRAM SHOWS THE PRICES OF INSTRUMENTS
namespace BlowOut.Controllers
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
    }
}