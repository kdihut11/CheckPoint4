using BlowOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class RentalController : Controller
    {
        public ActionResult Rentals()
        {
            return View();
        }

        public ActionResult ListRentals()
        {
            return View(InstrumentType.Types);
        }

        public ActionResult NewRental(string InstrumentName)
        {
            ViewBag.InstrumentName = InstrumentName;
            ViewBag.InstrumentImage = Instruments.InstrumentPictures[InstrumentName];
            ViewBag.NewPrice = Instruments.NewPrices[InstrumentName];
            ViewBag.UsedPrice = Instruments.UsedPrices[InstrumentName];
            return View();
        }
    }
}