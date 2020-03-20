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
    public class CAJAS_HistorialPagoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAJAS_HistorialPago
        public ActionResult Index()
        {
            return View(db.CAJAS_HistorialPago.ToList());
        }

        // GET: CAJAS_HistorialPago/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_HistorialPago cAJAS_HistorialPago = db.CAJAS_HistorialPago.Find(id);
            if (cAJAS_HistorialPago == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_HistorialPago);
        }

        // GET: CAJAS_HistorialPago/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAJAS_HistorialPago/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPago,FolioOperacion,Cantidad,IdFormaDePago,IdUbicacionDePago,FechaDePago,FechaDeCancelacion,MotivoCancelacion,idUsuario,referencia,Clave,NumeroDeCuenta,NombreSolicitante,ApellidoPaternoSolicitante,ApellidoMaternoSolicitante,idUsuarioCobro")] CAJAS_HistorialPago cAJAS_HistorialPago)
        {
            if (ModelState.IsValid)
            {
                db.CAJAS_HistorialPago.Add(cAJAS_HistorialPago);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAJAS_HistorialPago);
        }

        // GET: CAJAS_HistorialPago/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_HistorialPago cAJAS_HistorialPago = db.CAJAS_HistorialPago.Find(id);
            if (cAJAS_HistorialPago == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_HistorialPago);
        }

        // POST: CAJAS_HistorialPago/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPago,FolioOperacion,Cantidad,IdFormaDePago,IdUbicacionDePago,FechaDePago,FechaDeCancelacion,MotivoCancelacion,idUsuario,referencia,Clave,NumeroDeCuenta,NombreSolicitante,ApellidoPaternoSolicitante,ApellidoMaternoSolicitante,idUsuarioCobro")] CAJAS_HistorialPago cAJAS_HistorialPago)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAJAS_HistorialPago).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAJAS_HistorialPago);
        }

        // GET: CAJAS_HistorialPago/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_HistorialPago cAJAS_HistorialPago = db.CAJAS_HistorialPago.Find(id);
            if (cAJAS_HistorialPago == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_HistorialPago);
        }

        // POST: CAJAS_HistorialPago/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAJAS_HistorialPago cAJAS_HistorialPago = db.CAJAS_HistorialPago.Find(id);
            db.CAJAS_HistorialPago.Remove(cAJAS_HistorialPago);
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
