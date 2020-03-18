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
    public class CANCELADO_SIS_DetallesDeDescuentosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CANCELADO_SIS_DetallesDeDescuentos
        public ActionResult Index()
        {
            return View(db.CANCELADO_SIS_DetallesDeDescuentos.ToList());
        }

        // GET: CANCELADO_SIS_DetallesDeDescuentos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_DetallesDeDescuentos cANCELADO_SIS_DetallesDeDescuentos = db.CANCELADO_SIS_DetallesDeDescuentos.Find(id);
            if (cANCELADO_SIS_DetallesDeDescuentos == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_DetallesDeDescuentos);
        }

        // GET: CANCELADO_SIS_DetallesDeDescuentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CANCELADO_SIS_DetallesDeDescuentos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdDetallesDescuentos,Clave,NumeroDeCuenta,IdTipoDescuento,IdAñoDeDescuento,Descuento,FechaDeAplicacion,FolioOperacion")] CANCELADO_SIS_DetallesDeDescuentos cANCELADO_SIS_DetallesDeDescuentos)
        {
            if (ModelState.IsValid)
            {
                db.CANCELADO_SIS_DetallesDeDescuentos.Add(cANCELADO_SIS_DetallesDeDescuentos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cANCELADO_SIS_DetallesDeDescuentos);
        }

        // GET: CANCELADO_SIS_DetallesDeDescuentos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_DetallesDeDescuentos cANCELADO_SIS_DetallesDeDescuentos = db.CANCELADO_SIS_DetallesDeDescuentos.Find(id);
            if (cANCELADO_SIS_DetallesDeDescuentos == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_DetallesDeDescuentos);
        }

        // POST: CANCELADO_SIS_DetallesDeDescuentos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdDetallesDescuentos,Clave,NumeroDeCuenta,IdTipoDescuento,IdAñoDeDescuento,Descuento,FechaDeAplicacion,FolioOperacion")] CANCELADO_SIS_DetallesDeDescuentos cANCELADO_SIS_DetallesDeDescuentos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cANCELADO_SIS_DetallesDeDescuentos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cANCELADO_SIS_DetallesDeDescuentos);
        }

        // GET: CANCELADO_SIS_DetallesDeDescuentos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_DetallesDeDescuentos cANCELADO_SIS_DetallesDeDescuentos = db.CANCELADO_SIS_DetallesDeDescuentos.Find(id);
            if (cANCELADO_SIS_DetallesDeDescuentos == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_DetallesDeDescuentos);
        }

        // POST: CANCELADO_SIS_DetallesDeDescuentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CANCELADO_SIS_DetallesDeDescuentos cANCELADO_SIS_DetallesDeDescuentos = db.CANCELADO_SIS_DetallesDeDescuentos.Find(id);
            db.CANCELADO_SIS_DetallesDeDescuentos.Remove(cANCELADO_SIS_DetallesDeDescuentos);
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
