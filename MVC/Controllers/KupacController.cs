﻿using MVC.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class KupacController : Controller
    {
        Repo repo = new Repo();
        public ActionResult Index()
        {
            if (User.IsInRole("administrator"))
            {
                return Content("Ulazi");
            }
            return Content("Nelazi");
        }
    }
}