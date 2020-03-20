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
    public class CAJAS_HistorialUbicacionController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAJAS_HistorialUbicacion
        public ActionResult Index()
        {
            return View(db.CAJAS_HistorialUbicacion.ToList());
        }

        // GET: CAJAS_HistorialUbicacion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_HistorialUbicacion cAJAS_HistorialUbicacion = db.CAJAS_HistorialUbicacion.Find(id);
            if (cAJAS_HistorialUbicacion == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_HistorialUbicacion);
        }

        // GET: CAJAS_HistorialUbicacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAJAS_HistorialUbicacion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NombreUbicacionDePago,FechaDeBaja,IdUsuarioDeCobro,FechaDeAlta,IdUsuarioBaja")] CAJAS_HistorialUbicacion cAJAS_HistorialUbicacion)
        {
            if (ModelState.IsValid)
            {
                db.CAJAS_HistorialUbicacion.Add(cAJAS_HistorialUbicacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAJAS_HistorialUbicacion);
        }

        // GET: CAJAS_HistorialUbicacion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_HistorialUbicacion cAJAS_HistorialUbicacion = db.CAJAS_HistorialUbicacion.Find(id);
            if (cAJAS_HistorialUbicacion == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_HistorialUbicacion);
        }

        // POST: CAJAS_HistorialUbicacion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NombreUbicacionDePago,FechaDeBaja,IdUsuarioDeCobro,FechaDeAlta,IdUsuarioBaja")] CAJAS_HistorialUbicacion cAJAS_HistorialUbicacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAJAS_HistorialUbicacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAJAS_HistorialUbicacion);
        }

        // GET: CAJAS_HistorialUbicacion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_HistorialUbicacion cAJAS_HistorialUbicacion = db.CAJAS_HistorialUbicacion.Find(id);
            if (cAJAS_HistorialUbicacion == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_HistorialUbicacion);
        }

        // POST: CAJAS_HistorialUbicacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAJAS_HistorialUbicacion cAJAS_HistorialUbicacion = db.CAJAS_HistorialUbicacion.Find(id);
            db.CAJAS_HistorialUbicacion.Remove(cAJAS_HistorialUbicacion);
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
