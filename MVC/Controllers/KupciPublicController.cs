using MVC.DAL;
using MVC.DAL.Repo;
using MVC.Models;
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
                return View("IndexAdmin", repo.GetKupacs());
            }
            return View(repo.GetKupacs());
        }
        public ActionResult Edit(int id)
        {
            KupacViewModel viewModel = new KupacViewModel
            {
                Kupac = repo.GetKupac(id),
                GetGrads = repo.GetGrads()
            };
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Save(KupacViewModel viewModel)
        {
            var kupacDB = repo.GetKupac(viewModel.Kupac.IDKupac);
            kupacDB.Ime = viewModel.Kupac.Ime;
            kupacDB.Prezime = viewModel.Kupac.Prezime;
            kupacDB.Email = viewModel.Kupac.Email;
            kupacDB.Telefon = viewModel.Kupac.Telefon;
            kupacDB.GradID = viewModel.Kupac.GradID;
            repo.save();
            return Redirect("Index");
        }
    }
}