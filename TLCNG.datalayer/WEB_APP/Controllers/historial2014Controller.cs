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
    public class historial2014Controller : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: historial2014
        public ActionResult Index()
        {
            return View(db.historial2014.ToList());
        }

        // GET: historial2014/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            historial2014 historial2014 = db.historial2014.Find(id);
            if (historial2014 == null)
            {
                return HttpNotFound();
            }
            return View(historial2014);
        }

        // GET: historial2014/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: historial2014/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Clave,NumeroDeCuenta,FechaDePago,Cantidad,IdFolio,FolioOperacion,AñoPagado,ApellidoPaterno,ApellidoMaterno,Nombre")] historial2014 historial2014)
        {
            if (ModelState.IsValid)
            {
                db.historial2014.Add(historial2014);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(historial2014);
        }

        // GET: historial2014/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            historial2014 historial2014 = db.historial2014.Find(id);
            if (historial2014 == null)
            {
                return HttpNotFound();
            }
            return View(historial2014);
        }

        // POST: historial2014/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Clave,NumeroDeCuenta,FechaDePago,Cantidad,IdFolio,FolioOperacion,AñoPagado,ApellidoPaterno,ApellidoMaterno,Nombre")] historial2014 historial2014)
        {
            if (ModelState.IsValid)
            {
                db.Entry(historial2014).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(historial2014);
        }

        // GET: historial2014/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            historial2014 historial2014 = db.historial2014.Find(id);
            if (historial2014 == null)
            {
                return HttpNotFound();
            }
            return View(historial2014);
        }

        // POST: historial2014/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            historial2014 historial2014 = db.historial2014.Find(id);
            db.historial2014.Remove(historial2014);
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
