﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplikacja.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginPage()
        {
          //  ViewBag.Message = "Login Page";

            return View();
        }

        public ActionResult RegistryPage()
        {
         //   ViewBag.Message = "Register Page";

            return View();
        }
    }
}