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
    public class CAT_CoordinacionController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_Coordinacion
        public ActionResult Index()
        {
            return View(db.CAT_Coordinacion.ToList());
        }

        // GET: CAT_Coordinacion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_Coordinacion cAT_Coordinacion = db.CAT_Coordinacion.Find(id);
            if (cAT_Coordinacion == null)
            {
                return HttpNotFound();
            }
            return View(cAT_Coordinacion);
        }

        // GET: CAT_Coordinacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_Coordinacion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre,jerarquia")] CAT_Coordinacion cAT_Coordinacion)
        {
            if (ModelState.IsValid)
            {
                db.CAT_Coordinacion.Add(cAT_Coordinacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_Coordinacion);
        }

        // GET: CAT_Coordinacion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_Coordinacion cAT_Coordinacion = db.CAT_Coordinacion.Find(id);
            if (cAT_Coordinacion == null)
            {
                return HttpNotFound();
            }
            return View(cAT_Coordinacion);
        }

        // POST: CAT_Coordinacion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre,jerarquia")] CAT_Coordinacion cAT_Coordinacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_Coordinacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_Coordinacion);
        }

        // GET: CAT_Coordinacion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_Coordinacion cAT_Coordinacion = db.CAT_Coordinacion.Find(id);
            if (cAT_Coordinacion == null)
            {
                return HttpNotFound();
            }
            return View(cAT_Coordinacion);
        }

        // POST: CAT_Coordinacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_Coordinacion cAT_Coordinacion = db.CAT_Coordinacion.Find(id);
            db.CAT_Coordinacion.Remove(cAT_Coordinacion);
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
