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
    public class CAJAS_PagosPendientesCatastroController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAJAS_PagosPendientesCatastro
        public ActionResult Index()
        {
            return View(db.CAJAS_PagosPendientesCatastro.ToList());
        }

        // GET: CAJAS_PagosPendientesCatastro/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_PagosPendientesCatastro cAJAS_PagosPendientesCatastro = db.CAJAS_PagosPendientesCatastro.Find(id);
            if (cAJAS_PagosPendientesCatastro == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_PagosPendientesCatastro);
        }

        // GET: CAJAS_PagosPendientesCatastro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAJAS_PagosPendientesCatastro/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdFolio,IdTipoOperacion,ClaveCatastral,Clave,NumeroDeCuenta")] CAJAS_PagosPendientesCatastro cAJAS_PagosPendientesCatastro)
        {
            if (ModelState.IsValid)
            {
                db.CAJAS_PagosPendientesCatastro.Add(cAJAS_PagosPendientesCatastro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAJAS_PagosPendientesCatastro);
        }

        // GET: CAJAS_PagosPendientesCatastro/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_PagosPendientesCatastro cAJAS_PagosPendientesCatastro = db.CAJAS_PagosPendientesCatastro.Find(id);
            if (cAJAS_PagosPendientesCatastro == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_PagosPendientesCatastro);
        }

        // POST: CAJAS_PagosPendientesCatastro/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdFolio,IdTipoOperacion,ClaveCatastral,Clave,NumeroDeCuenta")] CAJAS_PagosPendientesCatastro cAJAS_PagosPendientesCatastro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAJAS_PagosPendientesCatastro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAJAS_PagosPendientesCatastro);
        }

        // GET: CAJAS_PagosPendientesCatastro/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_PagosPendientesCatastro cAJAS_PagosPendientesCatastro = db.CAJAS_PagosPendientesCatastro.Find(id);
            if (cAJAS_PagosPendientesCatastro == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_PagosPendientesCatastro);
        }

        // POST: CAJAS_PagosPendientesCatastro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAJAS_PagosPendientesCatastro cAJAS_PagosPendientesCatastro = db.CAJAS_PagosPendientesCatastro.Find(id);
            db.CAJAS_PagosPendientesCatastro.Remove(cAJAS_PagosPendientesCatastro);
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
