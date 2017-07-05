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
    }
}