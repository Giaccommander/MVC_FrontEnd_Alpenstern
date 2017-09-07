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
        public ActionResult Index()
        {
            return View();
        }

		[HttpPost]
        public ActionResult Login(string email, string passwort)
        {
			//var login = new Login();
			var db = new alpensternEntities();
			SqlConnection conn = new SqlConnection();
			SqlCommand comm = new SqlCommand("EXEC get_user_salt(" + email + ");");
			string salt = (string)comm.ExecuteScalar();
			string hashedPasswort = Hasher.hash(passwort + salt);
			comm = new SqlCommand("EXEC login_user(" + email + ", " + hashedPasswort + ");");
			int? id = (int?)comm.ExecuteScalar();
			if (id != null)
			{
				Session["user"] = db.Login.Find(id);
				return View();
			}
            return RedirectToAction("Index");
        }
    }
}