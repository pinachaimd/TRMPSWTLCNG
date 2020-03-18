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
    public class CAT_CAJAS_PagoMinimoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_CAJAS_PagoMinimo
        public ActionResult Index()
        {
            return View(db.CAT_CAJAS_PagoMinimo.ToList());
        }

        // GET: CAT_CAJAS_PagoMinimo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_CAJAS_PagoMinimo cAT_CAJAS_PagoMinimo = db.CAT_CAJAS_PagoMinimo.Find(id);
            if (cAT_CAJAS_PagoMinimo == null)
            {
                return HttpNotFound();
            }
            return View(cAT_CAJAS_PagoMinimo);
        }

        // GET: CAT_CAJAS_PagoMinimo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_CAJAS_PagoMinimo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,valorMinimo,descripcion,año,fechaAlta,fechaModificacion")] CAT_CAJAS_PagoMinimo cAT_CAJAS_PagoMinimo)
        {
            if (ModelState.IsValid)
            {
                db.CAT_CAJAS_PagoMinimo.Add(cAT_CAJAS_PagoMinimo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_CAJAS_PagoMinimo);
        }

        // GET: CAT_CAJAS_PagoMinimo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_CAJAS_PagoMinimo cAT_CAJAS_PagoMinimo = db.CAT_CAJAS_PagoMinimo.Find(id);
            if (cAT_CAJAS_PagoMinimo == null)
            {
                return HttpNotFound();
            }
            return View(cAT_CAJAS_PagoMinimo);
        }

        // POST: CAT_CAJAS_PagoMinimo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,valorMinimo,descripcion,año,fechaAlta,fechaModificacion")] CAT_CAJAS_PagoMinimo cAT_CAJAS_PagoMinimo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_CAJAS_PagoMinimo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_CAJAS_PagoMinimo);
        }

        // GET: CAT_CAJAS_PagoMinimo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_CAJAS_PagoMinimo cAT_CAJAS_PagoMinimo = db.CAT_CAJAS_PagoMinimo.Find(id);
            if (cAT_CAJAS_PagoMinimo == null)
            {
                return HttpNotFound();
            }
            return View(cAT_CAJAS_PagoMinimo);
        }

        // POST: CAT_CAJAS_PagoMinimo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_CAJAS_PagoMinimo cAT_CAJAS_PagoMinimo = db.CAT_CAJAS_PagoMinimo.Find(id);
            db.CAT_CAJAS_PagoMinimo.Remove(cAT_CAJAS_PagoMinimo);
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
