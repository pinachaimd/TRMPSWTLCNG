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
    public class SalariosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: Salarios
        public ActionResult Index()
        {
            return View(db.Salarios.ToList());
        }

        // GET: Salarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salarios salarios = db.Salarios.Find(id);
            if (salarios == null)
            {
                return HttpNotFound();
            }
            return View(salarios);
        }

        // GET: Salarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Salarios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdSalarios,Anio,BimestreAdeudado,MesesTranscurridos,PorcentajeRecargosMensuales,ClaveSalarios,AnioAnterior")] Salarios salarios)
        {
            if (ModelState.IsValid)
            {
                db.Salarios.Add(salarios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(salarios);
        }

        // GET: Salarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salarios salarios = db.Salarios.Find(id);
            if (salarios == null)
            {
                return HttpNotFound();
            }
            return View(salarios);
        }

        // POST: Salarios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdSalarios,Anio,BimestreAdeudado,MesesTranscurridos,PorcentajeRecargosMensuales,ClaveSalarios,AnioAnterior")] Salarios salarios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salarios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(salarios);
        }

        // GET: Salarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salarios salarios = db.Salarios.Find(id);
            if (salarios == null)
            {
                return HttpNotFound();
            }
            return View(salarios);
        }

        // POST: Salarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Salarios salarios = db.Salarios.Find(id);
            db.Salarios.Remove(salarios);
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
