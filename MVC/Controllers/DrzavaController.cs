using MVC.DAL;
using MVC.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class DrzavaController : Controller
    {
        Repo repo = new Repo();
        // GET: Drzava
        public ActionResult ViewAll()
        {
            return View(repo.GetDrzavas());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Drzava drzava)
        {
            repo.InsertDrzava(drzava);
            return Redirect("ViewAll");
        }
    }
}