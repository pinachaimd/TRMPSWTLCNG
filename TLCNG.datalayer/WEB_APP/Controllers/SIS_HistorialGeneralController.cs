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
    public class SIS_HistorialGeneralController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_HistorialGeneral
        public ActionResult Index()
        {
            return View(db.SIS_HistorialGeneral.ToList());
        }

        // GET: SIS_HistorialGeneral/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialGeneral sIS_HistorialGeneral = db.SIS_HistorialGeneral.Find(id);
            if (sIS_HistorialGeneral == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialGeneral);
        }

        // GET: SIS_HistorialGeneral/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_HistorialGeneral/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,idUsuario,fecha,hora,tablaAfectada,tipoMovimiento,descripcion,sistemaPertenece,NombreUsuario")] SIS_HistorialGeneral sIS_HistorialGeneral)
        {
            if (ModelState.IsValid)
            {
                db.SIS_HistorialGeneral.Add(sIS_HistorialGeneral);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_HistorialGeneral);
        }

        // GET: SIS_HistorialGeneral/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialGeneral sIS_HistorialGeneral = db.SIS_HistorialGeneral.Find(id);
            if (sIS_HistorialGeneral == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialGeneral);
        }

        // POST: SIS_HistorialGeneral/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idUsuario,fecha,hora,tablaAfectada,tipoMovimiento,descripcion,sistemaPertenece,NombreUsuario")] SIS_HistorialGeneral sIS_HistorialGeneral)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_HistorialGeneral).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_HistorialGeneral);
        }

        // GET: SIS_HistorialGeneral/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialGeneral sIS_HistorialGeneral = db.SIS_HistorialGeneral.Find(id);
            if (sIS_HistorialGeneral == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialGeneral);
        }

        // POST: SIS_HistorialGeneral/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_HistorialGeneral sIS_HistorialGeneral = db.SIS_HistorialGeneral.Find(id);
            db.SIS_HistorialGeneral.Remove(sIS_HistorialGeneral);
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
