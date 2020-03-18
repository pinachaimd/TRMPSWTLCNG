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
    public class CAJAS_PagosPredialController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAJAS_PagosPredial
        public ActionResult Index()
        {
            return View(db.CAJAS_PagosPredial.ToList());
        }

        // GET: CAJAS_PagosPredial/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_PagosPredial cAJAS_PagosPredial = db.CAJAS_PagosPredial.Find(id);
            if (cAJAS_PagosPredial == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_PagosPredial);
        }

        // GET: CAJAS_PagosPredial/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAJAS_PagosPredial/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPago,IdFolio,Clave,NumeroDeCuenta,NombreSolicitante,ApellidoPaternoSolicitante,ApellidoMaternoSolicitante,IdUsuario,BimestresPagados,AñoPagado,FolioOperacion")] CAJAS_PagosPredial cAJAS_PagosPredial)
        {
            if (ModelState.IsValid)
            {
                db.CAJAS_PagosPredial.Add(cAJAS_PagosPredial);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAJAS_PagosPredial);
        }

        // GET: CAJAS_PagosPredial/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_PagosPredial cAJAS_PagosPredial = db.CAJAS_PagosPredial.Find(id);
            if (cAJAS_PagosPredial == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_PagosPredial);
        }

        // POST: CAJAS_PagosPredial/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPago,IdFolio,Clave,NumeroDeCuenta,NombreSolicitante,ApellidoPaternoSolicitante,ApellidoMaternoSolicitante,IdUsuario,BimestresPagados,AñoPagado,FolioOperacion")] CAJAS_PagosPredial cAJAS_PagosPredial)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAJAS_PagosPredial).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAJAS_PagosPredial);
        }

        // GET: CAJAS_PagosPredial/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_PagosPredial cAJAS_PagosPredial = db.CAJAS_PagosPredial.Find(id);
            if (cAJAS_PagosPredial == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_PagosPredial);
        }

        // POST: CAJAS_PagosPredial/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAJAS_PagosPredial cAJAS_PagosPredial = db.CAJAS_PagosPredial.Find(id);
            db.CAJAS_PagosPredial.Remove(cAJAS_PagosPredial);
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
