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
    public class CANCELADO_CAJAS_PagosPredialController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CANCELADO_CAJAS_PagosPredial
        public ActionResult Index()
        {
            return View(db.CANCELADO_CAJAS_PagosPredial.ToList());
        }

        // GET: CANCELADO_CAJAS_PagosPredial/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_CAJAS_PagosPredial cANCELADO_CAJAS_PagosPredial = db.CANCELADO_CAJAS_PagosPredial.Find(id);
            if (cANCELADO_CAJAS_PagosPredial == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_CAJAS_PagosPredial);
        }

        // GET: CANCELADO_CAJAS_PagosPredial/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CANCELADO_CAJAS_PagosPredial/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPago,IdFolio,Clave,NumeroDeCuenta,NombreSolicitante,ApellidoPaternoSolicitante,ApellidoMaternoSolicitante,IdUsuario,BimestresPagados,AñoPagado,FolioOperacion")] CANCELADO_CAJAS_PagosPredial cANCELADO_CAJAS_PagosPredial)
        {
            if (ModelState.IsValid)
            {
                db.CANCELADO_CAJAS_PagosPredial.Add(cANCELADO_CAJAS_PagosPredial);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cANCELADO_CAJAS_PagosPredial);
        }

        // GET: CANCELADO_CAJAS_PagosPredial/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_CAJAS_PagosPredial cANCELADO_CAJAS_PagosPredial = db.CANCELADO_CAJAS_PagosPredial.Find(id);
            if (cANCELADO_CAJAS_PagosPredial == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_CAJAS_PagosPredial);
        }

        // POST: CANCELADO_CAJAS_PagosPredial/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPago,IdFolio,Clave,NumeroDeCuenta,NombreSolicitante,ApellidoPaternoSolicitante,ApellidoMaternoSolicitante,IdUsuario,BimestresPagados,AñoPagado,FolioOperacion")] CANCELADO_CAJAS_PagosPredial cANCELADO_CAJAS_PagosPredial)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cANCELADO_CAJAS_PagosPredial).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cANCELADO_CAJAS_PagosPredial);
        }

        // GET: CANCELADO_CAJAS_PagosPredial/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_CAJAS_PagosPredial cANCELADO_CAJAS_PagosPredial = db.CANCELADO_CAJAS_PagosPredial.Find(id);
            if (cANCELADO_CAJAS_PagosPredial == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_CAJAS_PagosPredial);
        }

        // POST: CANCELADO_CAJAS_PagosPredial/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CANCELADO_CAJAS_PagosPredial cANCELADO_CAJAS_PagosPredial = db.CANCELADO_CAJAS_PagosPredial.Find(id);
            db.CANCELADO_CAJAS_PagosPredial.Remove(cANCELADO_CAJAS_PagosPredial);
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
