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
    public class Indices1Controller : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: Indices1
        public ActionResult Index()
        {
            return View(db.Indices1.ToList());
        }

        // GET: Indices1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Indices1 indices1 = db.Indices1.Find(id);
            if (indices1 == null)
            {
                return HttpNotFound();
            }
            return View(indices1);
        }

        // GET: Indices1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Indices1/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdIndice,Mes,Anio,Indice,Fecha_Publicacion,Clave_Indices,MesTranscurrido,AnioMulta")] Indices1 indices1)
        {
            if (ModelState.IsValid)
            {
                db.Indices1.Add(indices1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(indices1);
        }

        // GET: Indices1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Indices1 indices1 = db.Indices1.Find(id);
            if (indices1 == null)
            {
                return HttpNotFound();
            }
            return View(indices1);
        }

        // POST: Indices1/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdIndice,Mes,Anio,Indice,Fecha_Publicacion,Clave_Indices,MesTranscurrido,AnioMulta")] Indices1 indices1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(indices1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(indices1);
        }

        // GET: Indices1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Indices1 indices1 = db.Indices1.Find(id);
            if (indices1 == null)
            {
                return HttpNotFound();
            }
            return View(indices1);
        }

        // POST: Indices1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Indices1 indices1 = db.Indices1.Find(id);
            db.Indices1.Remove(indices1);
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
