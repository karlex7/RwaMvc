using MVC.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class GradController : Controller
    {
        Repo repo = new Repo();
        public ActionResult ViewAll()
        {
            return View(repo.GetGrads());
        }
        public ActionResult Details(int id)
        {
            ViewBag.IDGrad = id;
            return View(repo.GetKupacs());
        }
        public ActionResult ViewRacuni(int id,string sortBy)
        {
            ViewBag.SortDateParameter = string.IsNullOrEmpty(sortBy) ? "Date desc" : "";
            ViewBag.SortKomercijalistParameter = sortBy== "Komprecijalist"?"Komprecijalist desc" : "";
            ViewBag.SortKreditnaTipParameter = sortBy == "KreditnaTip" ? "KreditnaTip desc" : "";
            ViewBag.IDKupac = id;
            ViewBag.KreditnaKartica = repo.GetKreditnaKarticas();

            switch (sortBy)
            {
                case "Date desc":
                    return View(repo.GetRacuns().OrderByDescending(x => x.DatumIzdavanja));
                case "Komprecijalist":
                    return View(repo.GetRacuns().OrderByDescending(x => x.KomercijalistID));
                case "KreditnaTip":
                    return View(repo.GetRacuns().OrderBy(x => x.KreditnaKarticaID));
                default:
                    return View(repo.GetRacuns().OrderByDescending(x => x.DatumIzdavanja));
            }
        }
        public ActionResult DetailsRacun(int id)
        {
            ViewBag.IDRacun = id;
            return View(repo.GetStavkas());
        }
    }
}