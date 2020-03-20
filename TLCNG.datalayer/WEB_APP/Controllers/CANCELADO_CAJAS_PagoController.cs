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
    public class CANCELADO_CAJAS_PagoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CANCELADO_CAJAS_Pago
        public ActionResult Index()
        {
            return View(db.CANCELADO_CAJAS_Pago.ToList());
        }

        // GET: CANCELADO_CAJAS_Pago/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_CAJAS_Pago cANCELADO_CAJAS_Pago = db.CANCELADO_CAJAS_Pago.Find(id);
            if (cANCELADO_CAJAS_Pago == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_CAJAS_Pago);
        }

        // GET: CANCELADO_CAJAS_Pago/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CANCELADO_CAJAS_Pago/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPago,IdFolio,Cantidad,IdFormaDePago,IdUbicacionDePago,FechaDePago,IdUsuarioDeCobro,Referencia")] CANCELADO_CAJAS_Pago cANCELADO_CAJAS_Pago)
        {
            if (ModelState.IsValid)
            {
                db.CANCELADO_CAJAS_Pago.Add(cANCELADO_CAJAS_Pago);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cANCELADO_CAJAS_Pago);
        }

        // GET: CANCELADO_CAJAS_Pago/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_CAJAS_Pago cANCELADO_CAJAS_Pago = db.CANCELADO_CAJAS_Pago.Find(id);
            if (cANCELADO_CAJAS_Pago == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_CAJAS_Pago);
        }

        // POST: CANCELADO_CAJAS_Pago/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPago,IdFolio,Cantidad,IdFormaDePago,IdUbicacionDePago,FechaDePago,IdUsuarioDeCobro,Referencia")] CANCELADO_CAJAS_Pago cANCELADO_CAJAS_Pago)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cANCELADO_CAJAS_Pago).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cANCELADO_CAJAS_Pago);
        }

        // GET: CANCELADO_CAJAS_Pago/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_CAJAS_Pago cANCELADO_CAJAS_Pago = db.CANCELADO_CAJAS_Pago.Find(id);
            if (cANCELADO_CAJAS_Pago == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_CAJAS_Pago);
        }

        // POST: CANCELADO_CAJAS_Pago/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CANCELADO_CAJAS_Pago cANCELADO_CAJAS_Pago = db.CANCELADO_CAJAS_Pago.Find(id);
            db.CANCELADO_CAJAS_Pago.Remove(cANCELADO_CAJAS_Pago);
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
