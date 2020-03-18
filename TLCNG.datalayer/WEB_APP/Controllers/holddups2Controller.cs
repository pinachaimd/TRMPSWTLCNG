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
    public class holddups2Controller : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: holddups2
        public ActionResult Index()
        {
            return View(db.holddups2.ToList());
        }

        // GET: holddups2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            holddups2 holddups2 = db.holddups2.Find(id);
            if (holddups2 == null)
            {
                return HttpNotFound();
            }
            return View(holddups2);
        }

        // GET: holddups2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: holddups2/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,AreaConstruccion,UsoDeSuelo,IdTipoDeConstruccion,Municipio,Edificio")] holddups2 holddups2)
        {
            if (ModelState.IsValid)
            {
                db.holddups2.Add(holddups2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(holddups2);
        }

        // GET: holddups2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            holddups2 holddups2 = db.holddups2.Find(id);
            if (holddups2 == null)
            {
                return HttpNotFound();
            }
            return View(holddups2);
        }

        // POST: holddups2/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,AreaConstruccion,UsoDeSuelo,IdTipoDeConstruccion,Municipio,Edificio")] holddups2 holddups2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(holddups2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(holddups2);
        }

        // GET: holddups2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            holddups2 holddups2 = db.holddups2.Find(id);
            if (holddups2 == null)
            {
                return HttpNotFound();
            }
            return View(holddups2);
        }

        // POST: holddups2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            holddups2 holddups2 = db.holddups2.Find(id);
            db.holddups2.Remove(holddups2);
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
