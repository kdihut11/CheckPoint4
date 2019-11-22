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
            ViewBag.InstrumentImage = Instrument.InstrumentPictures[InstrumentName];
            ViewBag.NewPrice = Instrument.NewPrices[InstrumentName];
            ViewBag.UsedPrice = Instrument.UsedPrices[InstrumentName];
            return View();
        }
    }
}