using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Alpenstern_FrontEnd.Models;

namespace Alpenstern_FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Spa()
        {
            

            return View();
        }
        public ActionResult kulinarik()
        {
            return View();
        }
        public ActionResult hotel()
        {
            return View();
        }
        public ActionResult rueckruf()
        {
            return View();
        }
        public ActionResult geschichte()
        {
            return View();
        }
        public ActionResult Anreise()
        {
            return View();
        }


        [HttpPost]

        public JsonResult SaveForm(string vor, string nach, string ruf)
        {

            var anrufen = new Rueckruf();

            anrufen.name = vor+" "+nach;
            anrufen.telefon = ruf;         
            List<Login> Login = null;
            using (var db = new alpensternEntities())

            {
                try
                {
                    //schreibzugriff
                    db.Rueckruf.Add(anrufen);
                    db.SaveChanges();
                    //lesezugriff
                    Login = db.Login.ToList();

                    return Json(Login);
                }
                catch (Exception e)
                {

                    return Json("Name schon vorhanden!!" + e.Message);
                }

            }

        }



    }
}