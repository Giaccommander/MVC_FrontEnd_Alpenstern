using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Alpenstern_FrontEnd.Models;

namespace Alpenstern_FrontEnd.Controllers
{
    public class ZimmerController : Controller
    {
        // GET: Zimmer
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult kategorie()
		{
			return View();
		}

		public ActionResult zimmerKategorie(int id)
		{
			var db = new alpensternEntities();
			var dbKategorie = db.Kategorie;
			var kategorie = new KategorieVM(dbKategorie.id, dbKategorie.bezeichnung, dbKategorie.preis, dbKategorie.personenAnzahl, dbKategorie.groesse);
			return View(kategorie);
		}

        public ActionResult einzelzimmer()
        {
            return View();
        }
        public ActionResult kEinzelzimmer()
        {
            return View();
        }
        public ActionResult Juniorsuite()
        {
            return View();
        }
        public ActionResult SuiteTirol()
        {
            return View();
        }
        public ActionResult Zirbensuite()
        {
            return View();
        }
        public ActionResult Gletschersuite()
        {
            return View();
        }
        public ActionResult SuiteAlpenstern()
        {
            return View();
        }
        public ActionResult Buchung2()
        {
            return View();
        }
        public ActionResult Buchung3()
        {
            return View();
        }
        public ActionResult Buchung4()
        {
            return View();
        }
    }
}