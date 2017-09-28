using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alpenstern_FrontEnd.Controllers
{
    public class GuestBookController : Controller
    {
        // GET: GuestBook
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult NewEntry(string vname, string nname, string gb_message)
        {
            return Json(vname+nname+gb_message, JsonRequestBehavior.AllowGet);
        }
    }
}