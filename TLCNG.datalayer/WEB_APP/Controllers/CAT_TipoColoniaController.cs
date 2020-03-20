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
    public class CAT_TipoColoniaController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_TipoColonia
        public ActionResult Index()
        {
            return View(db.CAT_TipoColonia.ToList());
        }

        // GET: CAT_TipoColonia/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoColonia cAT_TipoColonia = db.CAT_TipoColonia.Find(id);
            if (cAT_TipoColonia == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoColonia);
        }

        // GET: CAT_TipoColonia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_TipoColonia/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTipoColonia,NombreTipoColonia,IdAbreviatura")] CAT_TipoColonia cAT_TipoColonia)
        {
            if (ModelState.IsValid)
            {
                db.CAT_TipoColonia.Add(cAT_TipoColonia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_TipoColonia);
        }

        // GET: CAT_TipoColonia/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoColonia cAT_TipoColonia = db.CAT_TipoColonia.Find(id);
            if (cAT_TipoColonia == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoColonia);
        }

        // POST: CAT_TipoColonia/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTipoColonia,NombreTipoColonia,IdAbreviatura")] CAT_TipoColonia cAT_TipoColonia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_TipoColonia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_TipoColonia);
        }

        // GET: CAT_TipoColonia/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoColonia cAT_TipoColonia = db.CAT_TipoColonia.Find(id);
            if (cAT_TipoColonia == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoColonia);
        }

        // POST: CAT_TipoColonia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_TipoColonia cAT_TipoColonia = db.CAT_TipoColonia.Find(id);
            db.CAT_TipoColonia.Remove(cAT_TipoColonia);
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
