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
    public class holdkey2Controller : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: holdkey2
        public ActionResult Index()
        {
            return View(db.holdkey2.ToList());
        }

        // GET: holdkey2/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            holdkey2 holdkey2 = db.holdkey2.Find(id);
            if (holdkey2 == null)
            {
                return HttpNotFound();
            }
            return View(holdkey2);
        }

        // GET: holdkey2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: holdkey2/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,AreaConstruccion,UsoDeSuelo,IdTipoDeConstruccion,Municipio,Edificio,total")] holdkey2 holdkey2)
        {
            if (ModelState.IsValid)
            {
                db.holdkey2.Add(holdkey2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(holdkey2);
        }

        // GET: holdkey2/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            holdkey2 holdkey2 = db.holdkey2.Find(id);
            if (holdkey2 == null)
            {
                return HttpNotFound();
            }
            return View(holdkey2);
        }

        // POST: holdkey2/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,AreaConstruccion,UsoDeSuelo,IdTipoDeConstruccion,Municipio,Edificio,total")] holdkey2 holdkey2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(holdkey2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(holdkey2);
        }

        // GET: holdkey2/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            holdkey2 holdkey2 = db.holdkey2.Find(id);
            if (holdkey2 == null)
            {
                return HttpNotFound();
            }
            return View(holdkey2);
        }

        // POST: holdkey2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            holdkey2 holdkey2 = db.holdkey2.Find(id);
            db.holdkey2.Remove(holdkey2);
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
