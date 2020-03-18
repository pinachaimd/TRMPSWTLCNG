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
    public class SIS_HectareasCobradasController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_HectareasCobradas
        public ActionResult Index()
        {
            return View(db.SIS_HectareasCobradas.ToList());
        }

        // GET: SIS_HectareasCobradas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HectareasCobradas sIS_HectareasCobradas = db.SIS_HectareasCobradas.Find(id);
            if (sIS_HectareasCobradas == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HectareasCobradas);
        }

        // GET: SIS_HectareasCobradas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_HectareasCobradas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NumeroHectareas,Clave,Cuenta,Precio,AñoDePago")] SIS_HectareasCobradas sIS_HectareasCobradas)
        {
            if (ModelState.IsValid)
            {
                db.SIS_HectareasCobradas.Add(sIS_HectareasCobradas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_HectareasCobradas);
        }

        // GET: SIS_HectareasCobradas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HectareasCobradas sIS_HectareasCobradas = db.SIS_HectareasCobradas.Find(id);
            if (sIS_HectareasCobradas == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HectareasCobradas);
        }

        // POST: SIS_HectareasCobradas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NumeroHectareas,Clave,Cuenta,Precio,AñoDePago")] SIS_HectareasCobradas sIS_HectareasCobradas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_HectareasCobradas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_HectareasCobradas);
        }

        // GET: SIS_HectareasCobradas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HectareasCobradas sIS_HectareasCobradas = db.SIS_HectareasCobradas.Find(id);
            if (sIS_HectareasCobradas == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HectareasCobradas);
        }

        // POST: SIS_HectareasCobradas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_HectareasCobradas sIS_HectareasCobradas = db.SIS_HectareasCobradas.Find(id);
            db.SIS_HectareasCobradas.Remove(sIS_HectareasCobradas);
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
