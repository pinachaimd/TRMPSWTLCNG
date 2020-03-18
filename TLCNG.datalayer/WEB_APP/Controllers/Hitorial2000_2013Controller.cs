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
    public class Hitorial2000_2013Controller : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: Hitorial2000_2013
        public ActionResult Index()
        {
            return View(db.Hitorial2000_2013.ToList());
        }

        // GET: Hitorial2000_2013/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hitorial2000_2013 hitorial2000_2013 = db.Hitorial2000_2013.Find(id);
            if (hitorial2000_2013 == null)
            {
                return HttpNotFound();
            }
            return View(hitorial2000_2013);
        }

        // GET: Hitorial2000_2013/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hitorial2000_2013/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Clave,NumeroDeCuenta,FechaDePago,Cantidad,IdFolio,FolioOperacion,AñoPagado,ApellidoPaterno,ApellidoMaterno,Nombre")] Hitorial2000_2013 hitorial2000_2013)
        {
            if (ModelState.IsValid)
            {
                db.Hitorial2000_2013.Add(hitorial2000_2013);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hitorial2000_2013);
        }

        // GET: Hitorial2000_2013/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hitorial2000_2013 hitorial2000_2013 = db.Hitorial2000_2013.Find(id);
            if (hitorial2000_2013 == null)
            {
                return HttpNotFound();
            }
            return View(hitorial2000_2013);
        }

        // POST: Hitorial2000_2013/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Clave,NumeroDeCuenta,FechaDePago,Cantidad,IdFolio,FolioOperacion,AñoPagado,ApellidoPaterno,ApellidoMaterno,Nombre")] Hitorial2000_2013 hitorial2000_2013)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hitorial2000_2013).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hitorial2000_2013);
        }

        // GET: Hitorial2000_2013/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hitorial2000_2013 hitorial2000_2013 = db.Hitorial2000_2013.Find(id);
            if (hitorial2000_2013 == null)
            {
                return HttpNotFound();
            }
            return View(hitorial2000_2013);
        }

        // POST: Hitorial2000_2013/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Hitorial2000_2013 hitorial2000_2013 = db.Hitorial2000_2013.Find(id);
            db.Hitorial2000_2013.Remove(hitorial2000_2013);
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
