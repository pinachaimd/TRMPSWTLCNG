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
    public class Historial2000_2013norepetidosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: Historial2000_2013norepetidos
        public ActionResult Index()
        {
            return View(db.Historial2000_2013norepetidos.ToList());
        }

        // GET: Historial2000_2013norepetidos/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Historial2000_2013norepetidos historial2000_2013norepetidos = db.Historial2000_2013norepetidos.Find(id);
            if (historial2000_2013norepetidos == null)
            {
                return HttpNotFound();
            }
            return View(historial2000_2013norepetidos);
        }

        // GET: Historial2000_2013norepetidos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Historial2000_2013norepetidos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Clave,NumeroDeCuenta,cantidad,ApellidoPaterno,ApellidoMaterno,Nombre")] Historial2000_2013norepetidos historial2000_2013norepetidos)
        {
            if (ModelState.IsValid)
            {
                db.Historial2000_2013norepetidos.Add(historial2000_2013norepetidos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(historial2000_2013norepetidos);
        }

        // GET: Historial2000_2013norepetidos/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Historial2000_2013norepetidos historial2000_2013norepetidos = db.Historial2000_2013norepetidos.Find(id);
            if (historial2000_2013norepetidos == null)
            {
                return HttpNotFound();
            }
            return View(historial2000_2013norepetidos);
        }

        // POST: Historial2000_2013norepetidos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Clave,NumeroDeCuenta,cantidad,ApellidoPaterno,ApellidoMaterno,Nombre")] Historial2000_2013norepetidos historial2000_2013norepetidos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(historial2000_2013norepetidos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(historial2000_2013norepetidos);
        }

        // GET: Historial2000_2013norepetidos/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Historial2000_2013norepetidos historial2000_2013norepetidos = db.Historial2000_2013norepetidos.Find(id);
            if (historial2000_2013norepetidos == null)
            {
                return HttpNotFound();
            }
            return View(historial2000_2013norepetidos);
        }

        // POST: Historial2000_2013norepetidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Historial2000_2013norepetidos historial2000_2013norepetidos = db.Historial2000_2013norepetidos.Find(id);
            db.Historial2000_2013norepetidos.Remove(historial2000_2013norepetidos);
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
