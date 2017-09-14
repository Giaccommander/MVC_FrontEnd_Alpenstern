using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Alpenstern_FrontEnd.Models;
using Alpenstern_FrontEnd.Helper;
using System.Data.SqlClient;

namespace Alpenstern_FrontEnd.Controllers
{
    public class RegistrierungController : Controller
    {
        // GET: Registrierung
        public ActionResult Index(string status = null)
        {
			ViewBag.status = status;
            return View();
        }

		[HttpPost]
		public ActionResult register(string benutzername, string passwort, string passwortWh)
		{
			if (benutzername == "")
				return RedirectToAction("Index", "Benutzername fehlt");
			if (passwort == "")
				return RedirectToAction("Index", "Passwort fehlt");
			if (passwort != passwortWh)
				return RedirectToAction("Index", "Passwörter stimmen nicht überein");
			string salt = Hasher.createSalt();
			SqlConnection conn = new SqlConnection();
			SqlCommand comm = new SqlCommand();
			return View();
		}
    }
}