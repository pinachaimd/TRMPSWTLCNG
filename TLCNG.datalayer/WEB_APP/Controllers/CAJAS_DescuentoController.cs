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
    public class CAJAS_DescuentoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAJAS_Descuento
        public ActionResult Index()
        {
            var cAJAS_Descuento = db.CAJAS_Descuento.Include(c => c.CAT_CAJAS_TipoDeDescuento);
            return View(cAJAS_Descuento.ToList());
        }

        // GET: CAJAS_Descuento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_Descuento cAJAS_Descuento = db.CAJAS_Descuento.Find(id);
            if (cAJAS_Descuento == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_Descuento);
        }

        // GET: CAJAS_Descuento/Create
        public ActionResult Create()
        {
            ViewBag.IdTipo = new SelectList(db.CAT_CAJAS_TipoDeDescuento, "IdTipo", "NombreDescuento");
            return View();
        }

        // POST: CAJAS_Descuento/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Año,IdTipo,Porcentaje,Activo")] CAJAS_Descuento cAJAS_Descuento)
        {
            if (ModelState.IsValid)
            {
                db.CAJAS_Descuento.Add(cAJAS_Descuento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdTipo = new SelectList(db.CAT_CAJAS_TipoDeDescuento, "IdTipo", "NombreDescuento", cAJAS_Descuento.IdTipo);
            return View(cAJAS_Descuento);
        }

        // GET: CAJAS_Descuento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_Descuento cAJAS_Descuento = db.CAJAS_Descuento.Find(id);
            if (cAJAS_Descuento == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdTipo = new SelectList(db.CAT_CAJAS_TipoDeDescuento, "IdTipo", "NombreDescuento", cAJAS_Descuento.IdTipo);
            return View(cAJAS_Descuento);
        }

        // POST: CAJAS_Descuento/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Año,IdTipo,Porcentaje,Activo")] CAJAS_Descuento cAJAS_Descuento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAJAS_Descuento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdTipo = new SelectList(db.CAT_CAJAS_TipoDeDescuento, "IdTipo", "NombreDescuento", cAJAS_Descuento.IdTipo);
            return View(cAJAS_Descuento);
        }

        // GET: CAJAS_Descuento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_Descuento cAJAS_Descuento = db.CAJAS_Descuento.Find(id);
            if (cAJAS_Descuento == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_Descuento);
        }

        // POST: CAJAS_Descuento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAJAS_Descuento cAJAS_Descuento = db.CAJAS_Descuento.Find(id);
            db.CAJAS_Descuento.Remove(cAJAS_Descuento);
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
