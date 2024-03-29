﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlowOut.Models;
using System.Net;
using System.Net.Mail;


namespace BlowOut.Controllers
{
    public class EmailSetupController : Controller
    {
        // GET: EmailSetup
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(BlowOut.Models.Gmail model)
        {
            MailMessage mm = new MailMessage("keara.hutchinson@gmail.com", model.to);
            mm.Subject = model.subject;
            mm.Body = model.body;
            mm.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            NetworkCredential nc = new NetworkCredential("keara.hutchinson@gmail.com", "KearaD58");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = nc;
            smtp.Send(mm);

            ViewBag.message = "Mail has been sent successfully";

            return View();
        }
    }
}