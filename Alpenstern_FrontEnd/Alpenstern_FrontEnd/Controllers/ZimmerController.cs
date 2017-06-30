using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alpenstern_FrontEnd.Controllers
{
    public class ZimmerController : Controller
    {
        // GET: Zimmer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult einzelzimmer()
        {
            return View();
        }
    }
}