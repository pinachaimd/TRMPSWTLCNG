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
    public class CAT_CAJAS_TipoDeDescuentoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_CAJAS_TipoDeDescuento
        public ActionResult Index()
        {
            return View(db.CAT_CAJAS_TipoDeDescuento.ToList());
        }

        // GET: CAT_CAJAS_TipoDeDescuento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_CAJAS_TipoDeDescuento cAT_CAJAS_TipoDeDescuento = db.CAT_CAJAS_TipoDeDescuento.Find(id);
            if (cAT_CAJAS_TipoDeDescuento == null)
            {
                return HttpNotFound();
            }
            return View(cAT_CAJAS_TipoDeDescuento);
        }

        // GET: CAT_CAJAS_TipoDeDescuento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_CAJAS_TipoDeDescuento/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTipo,NombreDescuento")] CAT_CAJAS_TipoDeDescuento cAT_CAJAS_TipoDeDescuento)
        {
            if (ModelState.IsValid)
            {
                db.CAT_CAJAS_TipoDeDescuento.Add(cAT_CAJAS_TipoDeDescuento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_CAJAS_TipoDeDescuento);
        }

        // GET: CAT_CAJAS_TipoDeDescuento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_CAJAS_TipoDeDescuento cAT_CAJAS_TipoDeDescuento = db.CAT_CAJAS_TipoDeDescuento.Find(id);
            if (cAT_CAJAS_TipoDeDescuento == null)
            {
                return HttpNotFound();
            }
            return View(cAT_CAJAS_TipoDeDescuento);
        }

        // POST: CAT_CAJAS_TipoDeDescuento/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTipo,NombreDescuento")] CAT_CAJAS_TipoDeDescuento cAT_CAJAS_TipoDeDescuento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_CAJAS_TipoDeDescuento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_CAJAS_TipoDeDescuento);
        }

        // GET: CAT_CAJAS_TipoDeDescuento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_CAJAS_TipoDeDescuento cAT_CAJAS_TipoDeDescuento = db.CAT_CAJAS_TipoDeDescuento.Find(id);
            if (cAT_CAJAS_TipoDeDescuento == null)
            {
                return HttpNotFound();
            }
            return View(cAT_CAJAS_TipoDeDescuento);
        }

        // POST: CAT_CAJAS_TipoDeDescuento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_CAJAS_TipoDeDescuento cAT_CAJAS_TipoDeDescuento = db.CAT_CAJAS_TipoDeDescuento.Find(id);
            db.CAT_CAJAS_TipoDeDescuento.Remove(cAT_CAJAS_TipoDeDescuento);
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
