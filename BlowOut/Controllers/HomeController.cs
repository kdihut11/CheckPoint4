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

        public ActionResult Rentals()
        {
            return View();
        }

        public ActionResult Trumpet()
        {
            ViewBag.NewPrice = 55;
            ViewBag.UsedPrice = 25;
            return View();
        }

        public ActionResult Trombone()
        {
            ViewBag.NewPrice = 60;
            ViewBag.UsedPrice = 35;
            return View();
        }

        public ActionResult Tuba()
        {
            ViewBag.NewPrice = 70;
            ViewBag.UsedPrice = 50;
            return View();
        }

        public ActionResult Flute()
        {
            ViewBag.NewPrice = 40;
            ViewBag.UsedPrice = 25;
            return View();
        }

        public ActionResult Clarinet()
        {
            ViewBag.NewPrice = 35;
            ViewBag.UsedPrice = 27;
            return View();
        }

        public ActionResult Saxophone()
        {
            ViewBag.NewPrice = 42;
            ViewBag.UsedPrice = 30;
            return View();
        }
    }
}