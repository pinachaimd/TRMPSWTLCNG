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
    public class CAJAS_DatosTrasladoReciboController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAJAS_DatosTrasladoRecibo
        public ActionResult Index()
        {
            return View(db.CAJAS_DatosTrasladoRecibo.ToList());
        }

        // GET: CAJAS_DatosTrasladoRecibo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_DatosTrasladoRecibo cAJAS_DatosTrasladoRecibo = db.CAJAS_DatosTrasladoRecibo.Find(id);
            if (cAJAS_DatosTrasladoRecibo == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_DatosTrasladoRecibo);
        }

        // GET: CAJAS_DatosTrasladoRecibo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAJAS_DatosTrasladoRecibo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NombreAdjunto,NroTramite,CambioNombre,FolioOperacion")] CAJAS_DatosTrasladoRecibo cAJAS_DatosTrasladoRecibo)
        {
            if (ModelState.IsValid)
            {
                db.CAJAS_DatosTrasladoRecibo.Add(cAJAS_DatosTrasladoRecibo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAJAS_DatosTrasladoRecibo);
        }

        // GET: CAJAS_DatosTrasladoRecibo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_DatosTrasladoRecibo cAJAS_DatosTrasladoRecibo = db.CAJAS_DatosTrasladoRecibo.Find(id);
            if (cAJAS_DatosTrasladoRecibo == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_DatosTrasladoRecibo);
        }

        // POST: CAJAS_DatosTrasladoRecibo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NombreAdjunto,NroTramite,CambioNombre,FolioOperacion")] CAJAS_DatosTrasladoRecibo cAJAS_DatosTrasladoRecibo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAJAS_DatosTrasladoRecibo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAJAS_DatosTrasladoRecibo);
        }

        // GET: CAJAS_DatosTrasladoRecibo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_DatosTrasladoRecibo cAJAS_DatosTrasladoRecibo = db.CAJAS_DatosTrasladoRecibo.Find(id);
            if (cAJAS_DatosTrasladoRecibo == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_DatosTrasladoRecibo);
        }

        // POST: CAJAS_DatosTrasladoRecibo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAJAS_DatosTrasladoRecibo cAJAS_DatosTrasladoRecibo = db.CAJAS_DatosTrasladoRecibo.Find(id);
            db.CAJAS_DatosTrasladoRecibo.Remove(cAJAS_DatosTrasladoRecibo);
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
