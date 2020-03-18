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
    public class CAT_ActualImpuesPredialController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_ActualImpuesPredial
        public ActionResult Index()
        {
            return View(db.CAT_ActualImpuesPredial.ToList());
        }

        // GET: CAT_ActualImpuesPredial/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_ActualImpuesPredial cAT_ActualImpuesPredial = db.CAT_ActualImpuesPredial.Find(id);
            if (cAT_ActualImpuesPredial == null)
            {
                return HttpNotFound();
            }
            return View(cAT_ActualImpuesPredial);
        }

        // GET: CAT_ActualImpuesPredial/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_ActualImpuesPredial/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdActImpPre,NombreActualizacion,NombreActualizacion2,NombreActualizacion3,NombreActualizacion4,NombreActualizacion5,NombreActualizacion6,NombreActualizacion7,NombreActualizacion8,NombreActualizacion9,NombreActualizacion10,NombreActualizacion11,NombreActualizacion12,NombreActualizacion13,NombreActualizacion14,NombreActualizacion15,NombreActualizacion16,NombreActualizacion17")] CAT_ActualImpuesPredial cAT_ActualImpuesPredial)
        {
            if (ModelState.IsValid)
            {
                db.CAT_ActualImpuesPredial.Add(cAT_ActualImpuesPredial);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_ActualImpuesPredial);
        }

        // GET: CAT_ActualImpuesPredial/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_ActualImpuesPredial cAT_ActualImpuesPredial = db.CAT_ActualImpuesPredial.Find(id);
            if (cAT_ActualImpuesPredial == null)
            {
                return HttpNotFound();
            }
            return View(cAT_ActualImpuesPredial);
        }

        // POST: CAT_ActualImpuesPredial/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdActImpPre,NombreActualizacion,NombreActualizacion2,NombreActualizacion3,NombreActualizacion4,NombreActualizacion5,NombreActualizacion6,NombreActualizacion7,NombreActualizacion8,NombreActualizacion9,NombreActualizacion10,NombreActualizacion11,NombreActualizacion12,NombreActualizacion13,NombreActualizacion14,NombreActualizacion15,NombreActualizacion16,NombreActualizacion17")] CAT_ActualImpuesPredial cAT_ActualImpuesPredial)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_ActualImpuesPredial).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_ActualImpuesPredial);
        }

        // GET: CAT_ActualImpuesPredial/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_ActualImpuesPredial cAT_ActualImpuesPredial = db.CAT_ActualImpuesPredial.Find(id);
            if (cAT_ActualImpuesPredial == null)
            {
                return HttpNotFound();
            }
            return View(cAT_ActualImpuesPredial);
        }

        // POST: CAT_ActualImpuesPredial/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_ActualImpuesPredial cAT_ActualImpuesPredial = db.CAT_ActualImpuesPredial.Find(id);
            db.CAT_ActualImpuesPredial.Remove(cAT_ActualImpuesPredial);
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
