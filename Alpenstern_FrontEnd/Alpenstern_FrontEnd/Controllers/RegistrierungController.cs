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
        public ActionResult Index()
        {
            return View();
        }
    }
}