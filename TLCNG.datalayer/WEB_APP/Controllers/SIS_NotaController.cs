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
    public class SIS_NotaController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_Nota
        public ActionResult Index()
        {
            return View(db.SIS_Nota.ToList());
        }

        // GET: SIS_Nota/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_Nota sIS_Nota = db.SIS_Nota.Find(id);
            if (sIS_Nota == null)
            {
                return HttpNotFound();
            }
            return View(sIS_Nota);
        }

        // GET: SIS_Nota/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_Nota/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,tipoNota,clave,numeroDeCuenta,idColonia,manzana,nota,fecha")] SIS_Nota sIS_Nota)
        {
            if (ModelState.IsValid)
            {
                db.SIS_Nota.Add(sIS_Nota);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_Nota);
        }

        // GET: SIS_Nota/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_Nota sIS_Nota = db.SIS_Nota.Find(id);
            if (sIS_Nota == null)
            {
                return HttpNotFound();
            }
            return View(sIS_Nota);
        }

        // POST: SIS_Nota/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,tipoNota,clave,numeroDeCuenta,idColonia,manzana,nota,fecha")] SIS_Nota sIS_Nota)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_Nota).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_Nota);
        }

        // GET: SIS_Nota/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_Nota sIS_Nota = db.SIS_Nota.Find(id);
            if (sIS_Nota == null)
            {
                return HttpNotFound();
            }
            return View(sIS_Nota);
        }

        // POST: SIS_Nota/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            SIS_Nota sIS_Nota = db.SIS_Nota.Find(id);
            db.SIS_Nota.Remove(sIS_Nota);
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
