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
    public class SIS_DetallesDeDescuentosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_DetallesDeDescuentos
        public ActionResult Index()
        {
            return View(db.SIS_DetallesDeDescuentos.ToList());
        }

        // GET: SIS_DetallesDeDescuentos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_DetallesDeDescuentos sIS_DetallesDeDescuentos = db.SIS_DetallesDeDescuentos.Find(id);
            if (sIS_DetallesDeDescuentos == null)
            {
                return HttpNotFound();
            }
            return View(sIS_DetallesDeDescuentos);
        }

        // GET: SIS_DetallesDeDescuentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_DetallesDeDescuentos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdDetallesDescuentos,Clave,NumeroDeCuenta,IdTipoDescuento,IdAñoDeDescuento,Descuento,FechaDeAplicacion,FolioOperacion")] SIS_DetallesDeDescuentos sIS_DetallesDeDescuentos)
        {
            if (ModelState.IsValid)
            {
                db.SIS_DetallesDeDescuentos.Add(sIS_DetallesDeDescuentos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_DetallesDeDescuentos);
        }

        // GET: SIS_DetallesDeDescuentos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_DetallesDeDescuentos sIS_DetallesDeDescuentos = db.SIS_DetallesDeDescuentos.Find(id);
            if (sIS_DetallesDeDescuentos == null)
            {
                return HttpNotFound();
            }
            return View(sIS_DetallesDeDescuentos);
        }

        // POST: SIS_DetallesDeDescuentos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdDetallesDescuentos,Clave,NumeroDeCuenta,IdTipoDescuento,IdAñoDeDescuento,Descuento,FechaDeAplicacion,FolioOperacion")] SIS_DetallesDeDescuentos sIS_DetallesDeDescuentos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_DetallesDeDescuentos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_DetallesDeDescuentos);
        }

        // GET: SIS_DetallesDeDescuentos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_DetallesDeDescuentos sIS_DetallesDeDescuentos = db.SIS_DetallesDeDescuentos.Find(id);
            if (sIS_DetallesDeDescuentos == null)
            {
                return HttpNotFound();
            }
            return View(sIS_DetallesDeDescuentos);
        }

        // POST: SIS_DetallesDeDescuentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_DetallesDeDescuentos sIS_DetallesDeDescuentos = db.SIS_DetallesDeDescuentos.Find(id);
            db.SIS_DetallesDeDescuentos.Remove(sIS_DetallesDeDescuentos);
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
