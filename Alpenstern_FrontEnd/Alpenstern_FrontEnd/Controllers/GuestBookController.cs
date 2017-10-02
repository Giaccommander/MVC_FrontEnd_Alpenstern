using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Alpenstern_FrontEnd.Models;

namespace Alpenstern_FrontEnd.Controllers
{
    public class GuestBookController : Controller
    {

        alpensternEntities db = new alpensternEntities();

        // GET: GuestBook
        public ActionResult Index()
        {
            return View();
            //return View(db.GuestBook.ToList()); - Gaestebuch tabelle fehlt!!!!
        }

        //public JsonResult NewEntry(string vname, string nname, string gb_message)
        //{
        //    return Json(vname+nname+gb_message, JsonRequestBehavior.AllowGet);
        //}

        [HttpPost]
        public ActionResult gb_newMessage(string vname, string nname, string msg)
        {

            var newEntry = new GuestBook();

            newEntry.name = vname;
            newEntry.surname = nname;
            newEntry.msg = msg;

            try
            {
                //SCHREIBZUGRIFF    

                //db.GuestBook.Add(newEntry);
                db.SaveChanges();
                ViewBag.info = "Ihr Beitrag wird in kürze Online sein.";
            }
            catch (Exception e)
            {
               

            }
            return View();

        }

        [HttpGet]
        public ActionResult textGbCaroussel(TextCarouselGBVM vm)
        {
           var dbGast = db.Gast.ToList();
            var dbRuck = db.Rueckruf.ToList();
            foreach (var gast in dbGast)
            {
                var eintrag = new TextCarouselGBVM();
                eintrag.name = gast.vorname;
                eintrag.surname = gast.nachname;
                foreach (var ru in dbRuck)
                {
                    eintrag.msg = ru.grund;
                }
                vm.Liste.Add(eintrag);
            }
            return View(vm);
        }
    }
}