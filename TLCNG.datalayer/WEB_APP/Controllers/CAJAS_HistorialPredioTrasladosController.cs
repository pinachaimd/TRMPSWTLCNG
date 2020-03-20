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
    public class CAJAS_HistorialPredioTrasladosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAJAS_HistorialPredioTraslados
        public ActionResult Index()
        {
            return View(db.CAJAS_HistorialPredioTraslados.ToList());
        }

        // GET: CAJAS_HistorialPredioTraslados/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_HistorialPredioTraslados cAJAS_HistorialPredioTraslados = db.CAJAS_HistorialPredioTraslados.Find(id);
            if (cAJAS_HistorialPredioTraslados == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_HistorialPredioTraslados);
        }

        // GET: CAJAS_HistorialPredioTraslados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAJAS_HistorialPredioTraslados/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FolioTraslado,IdLocalidad,RFC,Calle,Numero,CodigoPostal,Ubicacion")] CAJAS_HistorialPredioTraslados cAJAS_HistorialPredioTraslados)
        {
            if (ModelState.IsValid)
            {
                db.CAJAS_HistorialPredioTraslados.Add(cAJAS_HistorialPredioTraslados);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAJAS_HistorialPredioTraslados);
        }

        // GET: CAJAS_HistorialPredioTraslados/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_HistorialPredioTraslados cAJAS_HistorialPredioTraslados = db.CAJAS_HistorialPredioTraslados.Find(id);
            if (cAJAS_HistorialPredioTraslados == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_HistorialPredioTraslados);
        }

        // POST: CAJAS_HistorialPredioTraslados/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FolioTraslado,IdLocalidad,RFC,Calle,Numero,CodigoPostal,Ubicacion")] CAJAS_HistorialPredioTraslados cAJAS_HistorialPredioTraslados)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAJAS_HistorialPredioTraslados).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAJAS_HistorialPredioTraslados);
        }

        // GET: CAJAS_HistorialPredioTraslados/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_HistorialPredioTraslados cAJAS_HistorialPredioTraslados = db.CAJAS_HistorialPredioTraslados.Find(id);
            if (cAJAS_HistorialPredioTraslados == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_HistorialPredioTraslados);
        }

        // POST: CAJAS_HistorialPredioTraslados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            CAJAS_HistorialPredioTraslados cAJAS_HistorialPredioTraslados = db.CAJAS_HistorialPredioTraslados.Find(id);
            db.CAJAS_HistorialPredioTraslados.Remove(cAJAS_HistorialPredioTraslados);
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
