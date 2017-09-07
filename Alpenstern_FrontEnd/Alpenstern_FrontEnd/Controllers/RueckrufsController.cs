using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Alpenstern_FrontEnd.Models;


namespace Alpenstern_FrontEnd.Controllers
{
    public class RueckrufsController : Controller
    {
        private alpensternEntities db = new alpensternEntities();

        // GET: Rueckrufs
        public ActionResult Index()
        {
            return View(db.Rueckruf.ToList());
        }

        // GET: Rueckrufs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rueckruf rueckruf = db.Rueckruf.Find(id);
            if (rueckruf == null)
            {
                return HttpNotFound();
            }
            return View(rueckruf);
        }

        // GET: Rueckrufs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rueckrufs/Create
        // Aktivieren Sie zum Schutz vor übermäßigem Senden von Angriffen die spezifischen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,telefon,grund,datum_erhalten,datum_erledigt")] Rueckruf rueckruf)
        {
            if (ModelState.IsValid)
            {
                db.Rueckruf.Add(rueckruf);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rueckruf);
        }

        // GET: Rueckrufs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rueckruf rueckruf = db.Rueckruf.Find(id);
            if (rueckruf == null)
            {
                return HttpNotFound();
            }
            return View(rueckruf);
        }

        // POST: Rueckrufs/Edit/5
        // Aktivieren Sie zum Schutz vor übermäßigem Senden von Angriffen die spezifischen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,telefon,grund,datum_erhalten,datum_erledigt")] Rueckruf rueckruf)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rueckruf).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rueckruf);
        }

        // GET: Rueckrufs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rueckruf rueckruf = db.Rueckruf.Find(id);
            if (rueckruf == null)
            {
                return HttpNotFound();
            }
            return View(rueckruf);
        }

        // POST: Rueckrufs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rueckruf rueckruf = db.Rueckruf.Find(id);
            db.Rueckruf.Remove(rueckruf);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
