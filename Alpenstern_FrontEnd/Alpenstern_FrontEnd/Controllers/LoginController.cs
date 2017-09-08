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
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index(string status = null)
        {
			ViewBag.status = status;
            return View();
        }

		[HttpPost]
        public ActionResult Login(string email, string passwort)
        {
			SqlConnection conn = new SqlConnection();
			SqlCommand comm = new SqlCommand("EXEC get_user_salt(" + email + ");");
			string salt = (string)comm.ExecuteScalar();
			string hashedPasswort = Hasher.hash(passwort + salt);
			comm = new SqlCommand("EXEC login_user(" + email + ", " + hashedPasswort + ");");
			int? id = (int?)comm.ExecuteScalar();
			if (id != null)
			{
				var db = new alpensternEntities();
				Session["user"] = db.Login.Find(id);
				return View();
			}
			return RedirectToAction("Index", "Login feherhaft");
        }
    }
}