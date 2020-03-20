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
    public class CAJAS_HistorialUsuariosBajaController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAJAS_HistorialUsuariosBaja
        public ActionResult Index()
        {
            return View(db.CAJAS_HistorialUsuariosBaja.ToList());
        }

        // GET: CAJAS_HistorialUsuariosBaja/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_HistorialUsuariosBaja cAJAS_HistorialUsuariosBaja = db.CAJAS_HistorialUsuariosBaja.Find(id);
            if (cAJAS_HistorialUsuariosBaja == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_HistorialUsuariosBaja);
        }

        // GET: CAJAS_HistorialUsuariosBaja/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAJAS_HistorialUsuariosBaja/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,NombreUbicacionDePago,FechaDeBaja,IdUsuarioDeCobro,IdUsuarioBaja")] CAJAS_HistorialUsuariosBaja cAJAS_HistorialUsuariosBaja)
        {
            if (ModelState.IsValid)
            {
                db.CAJAS_HistorialUsuariosBaja.Add(cAJAS_HistorialUsuariosBaja);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAJAS_HistorialUsuariosBaja);
        }

        // GET: CAJAS_HistorialUsuariosBaja/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_HistorialUsuariosBaja cAJAS_HistorialUsuariosBaja = db.CAJAS_HistorialUsuariosBaja.Find(id);
            if (cAJAS_HistorialUsuariosBaja == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_HistorialUsuariosBaja);
        }

        // POST: CAJAS_HistorialUsuariosBaja/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,NombreUbicacionDePago,FechaDeBaja,IdUsuarioDeCobro,IdUsuarioBaja")] CAJAS_HistorialUsuariosBaja cAJAS_HistorialUsuariosBaja)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAJAS_HistorialUsuariosBaja).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAJAS_HistorialUsuariosBaja);
        }

        // GET: CAJAS_HistorialUsuariosBaja/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_HistorialUsuariosBaja cAJAS_HistorialUsuariosBaja = db.CAJAS_HistorialUsuariosBaja.Find(id);
            if (cAJAS_HistorialUsuariosBaja == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_HistorialUsuariosBaja);
        }

        // POST: CAJAS_HistorialUsuariosBaja/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAJAS_HistorialUsuariosBaja cAJAS_HistorialUsuariosBaja = db.CAJAS_HistorialUsuariosBaja.Find(id);
            db.CAJAS_HistorialUsuariosBaja.Remove(cAJAS_HistorialUsuariosBaja);
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
