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
    public class CAJAS_PagoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAJAS_Pago
        public ActionResult Index()
        {
            var cAJAS_Pago = db.CAJAS_Pago.Include(c => c.CAT_CAJAS_FormaDePago);
            return View(cAJAS_Pago.ToList());
        }

        // GET: CAJAS_Pago/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_Pago cAJAS_Pago = db.CAJAS_Pago.Find(id);
            if (cAJAS_Pago == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_Pago);
        }

        // GET: CAJAS_Pago/Create
        public ActionResult Create()
        {
            ViewBag.IdFormaDePago = new SelectList(db.CAT_CAJAS_FormaDePago, "Id", "NombreFormaDePago");
            return View();
        }

        // POST: CAJAS_Pago/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPago,IdFolio,Cantidad,IdFormaDePago,IdUbicacionDePago,FechaDePago,IdUsuarioDeCobro,Referencia")] CAJAS_Pago cAJAS_Pago)
        {
            if (ModelState.IsValid)
            {
                db.CAJAS_Pago.Add(cAJAS_Pago);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdFormaDePago = new SelectList(db.CAT_CAJAS_FormaDePago, "Id", "NombreFormaDePago", cAJAS_Pago.IdFormaDePago);
            return View(cAJAS_Pago);
        }

        // GET: CAJAS_Pago/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_Pago cAJAS_Pago = db.CAJAS_Pago.Find(id);
            if (cAJAS_Pago == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdFormaDePago = new SelectList(db.CAT_CAJAS_FormaDePago, "Id", "NombreFormaDePago", cAJAS_Pago.IdFormaDePago);
            return View(cAJAS_Pago);
        }

        // POST: CAJAS_Pago/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPago,IdFolio,Cantidad,IdFormaDePago,IdUbicacionDePago,FechaDePago,IdUsuarioDeCobro,Referencia")] CAJAS_Pago cAJAS_Pago)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAJAS_Pago).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdFormaDePago = new SelectList(db.CAT_CAJAS_FormaDePago, "Id", "NombreFormaDePago", cAJAS_Pago.IdFormaDePago);
            return View(cAJAS_Pago);
        }

        // GET: CAJAS_Pago/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_Pago cAJAS_Pago = db.CAJAS_Pago.Find(id);
            if (cAJAS_Pago == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_Pago);
        }

        // POST: CAJAS_Pago/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAJAS_Pago cAJAS_Pago = db.CAJAS_Pago.Find(id);
            db.CAJAS_Pago.Remove(cAJAS_Pago);
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
