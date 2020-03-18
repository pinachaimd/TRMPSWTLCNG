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
    public class holddupsController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: holddups
        public ActionResult Index()
        {
            return View(db.holddups.ToList());
        }

        // GET: holddups/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            holddups holddups = db.holddups.Find(id);
            if (holddups == null)
            {
                return HttpNotFound();
            }
            return View(holddups);
        }

        // GET: holddups/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: holddups/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,AreaConstruccion,UsoDeSuelo,IdTipoDeConstruccion,Municipio,Edificio")] holddups holddups)
        {
            if (ModelState.IsValid)
            {
                db.holddups.Add(holddups);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(holddups);
        }

        // GET: holddups/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            holddups holddups = db.holddups.Find(id);
            if (holddups == null)
            {
                return HttpNotFound();
            }
            return View(holddups);
        }

        // POST: holddups/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,AreaConstruccion,UsoDeSuelo,IdTipoDeConstruccion,Municipio,Edificio")] holddups holddups)
        {
            if (ModelState.IsValid)
            {
                db.Entry(holddups).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(holddups);
        }

        // GET: holddups/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            holddups holddups = db.holddups.Find(id);
            if (holddups == null)
            {
                return HttpNotFound();
            }
            return View(holddups);
        }

        // POST: holddups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            holddups holddups = db.holddups.Find(id);
            db.holddups.Remove(holddups);
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
