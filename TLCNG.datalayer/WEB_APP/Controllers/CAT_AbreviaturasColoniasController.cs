using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TLCNG.datalayer;
using TLCNG.entities;

namespace WEB_APP.Controllers
{
    public class CAT_AbreviaturasColoniasController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_AbreviaturasColonias
        public ActionResult Index()
        {
            return View(db.CAT_AbreviaturasColonias.ToList());
        }

        // GET: CAT_AbreviaturasColonias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_AbreviaturasColonias cAT_AbreviaturasColonias = db.CAT_AbreviaturasColonias.Find(id);
            if (cAT_AbreviaturasColonias == null)
            {
                return HttpNotFound();
            }
            return View(cAT_AbreviaturasColonias);
        }

        // GET: CAT_AbreviaturasColonias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_AbreviaturasColonias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Abreviatura")] CAT_AbreviaturasColonias cAT_AbreviaturasColonias)
        {
            if (ModelState.IsValid)
            {
                db.CAT_AbreviaturasColonias.Add(cAT_AbreviaturasColonias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_AbreviaturasColonias);
        }

        // GET: CAT_AbreviaturasColonias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_AbreviaturasColonias cAT_AbreviaturasColonias = db.CAT_AbreviaturasColonias.Find(id);
            if (cAT_AbreviaturasColonias == null)
            {
                return HttpNotFound();
            }
            return View(cAT_AbreviaturasColonias);
        }

        // POST: CAT_AbreviaturasColonias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Abreviatura")] CAT_AbreviaturasColonias cAT_AbreviaturasColonias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_AbreviaturasColonias).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_AbreviaturasColonias);
        }

        // GET: CAT_AbreviaturasColonias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_AbreviaturasColonias cAT_AbreviaturasColonias = db.CAT_AbreviaturasColonias.Find(id);
            if (cAT_AbreviaturasColonias == null)
            {
                return HttpNotFound();
            }
            return View(cAT_AbreviaturasColonias);
        }

        // POST: CAT_AbreviaturasColonias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_AbreviaturasColonias cAT_AbreviaturasColonias = db.CAT_AbreviaturasColonias.Find(id);
            db.CAT_AbreviaturasColonias.Remove(cAT_AbreviaturasColonias);
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
