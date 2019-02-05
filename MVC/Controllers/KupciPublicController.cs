using MVC.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class KupciPublicController : Controller
    {
        Repo repo = new Repo();
        // GET: KupciPublic
        public ActionResult Index()
        {
            if (User.IsInRole("administrator"))
            {
                return View("IndexAdmin",repo.GetKupacs());
            }
            return View(repo.GetKupacs());
        }
    }
}