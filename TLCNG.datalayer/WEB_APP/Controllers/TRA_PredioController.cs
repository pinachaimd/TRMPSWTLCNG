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
    public class TRA_PredioController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: TRA_Predio
        public ActionResult Index()
        {
            return View(db.TRA_Predio.ToList());
        }

        // GET: TRA_Predio/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_Predio tRA_Predio = db.TRA_Predio.Find(id);
            if (tRA_Predio == null)
            {
                return HttpNotFound();
            }
            return View(tRA_Predio);
        }

        // GET: TRA_Predio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TRA_Predio/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,cuentaOrigen,claveOrigen,cuentaDestino,claveDestino,fechaDeMovimiento,numeroDeTramite")] TRA_Predio tRA_Predio)
        {
            if (ModelState.IsValid)
            {
                db.TRA_Predio.Add(tRA_Predio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tRA_Predio);
        }

        // GET: TRA_Predio/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_Predio tRA_Predio = db.TRA_Predio.Find(id);
            if (tRA_Predio == null)
            {
                return HttpNotFound();
            }
            return View(tRA_Predio);
        }

        // POST: TRA_Predio/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,cuentaOrigen,claveOrigen,cuentaDestino,claveDestino,fechaDeMovimiento,numeroDeTramite")] TRA_Predio tRA_Predio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tRA_Predio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tRA_Predio);
        }

        // GET: TRA_Predio/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_Predio tRA_Predio = db.TRA_Predio.Find(id);
            if (tRA_Predio == null)
            {
                return HttpNotFound();
            }
            return View(tRA_Predio);
        }

        // POST: TRA_Predio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TRA_Predio tRA_Predio = db.TRA_Predio.Find(id);
            db.TRA_Predio.Remove(tRA_Predio);
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
