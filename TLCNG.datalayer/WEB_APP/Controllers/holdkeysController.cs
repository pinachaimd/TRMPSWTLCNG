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
    public class holdkeysController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: holdkeys
        public ActionResult Index()
        {
            return View(db.holdkey.ToList());
        }

        // GET: holdkeys/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            holdkey holdkey = db.holdkey.Find(id);
            if (holdkey == null)
            {
                return HttpNotFound();
            }
            return View(holdkey);
        }

        // GET: holdkeys/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: holdkeys/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,AreaConstruccion,UsoDeSuelo,IdTipoDeConstruccion,Municipio,Edificio,total")] holdkey holdkey)
        {
            if (ModelState.IsValid)
            {
                db.holdkey.Add(holdkey);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(holdkey);
        }

        // GET: holdkeys/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            holdkey holdkey = db.holdkey.Find(id);
            if (holdkey == null)
            {
                return HttpNotFound();
            }
            return View(holdkey);
        }

        // POST: holdkeys/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,AreaConstruccion,UsoDeSuelo,IdTipoDeConstruccion,Municipio,Edificio,total")] holdkey holdkey)
        {
            if (ModelState.IsValid)
            {
                db.Entry(holdkey).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(holdkey);
        }

        // GET: holdkeys/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            holdkey holdkey = db.holdkey.Find(id);
            if (holdkey == null)
            {
                return HttpNotFound();
            }
            return View(holdkey);
        }

        // POST: holdkeys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            holdkey holdkey = db.holdkey.Find(id);
            db.holdkey.Remove(holdkey);
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
