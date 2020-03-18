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
    public class CAT_TiposDeVialidadController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_TiposDeVialidad
        public ActionResult Index()
        {
            return View(db.CAT_TiposDeVialidad.ToList());
        }

        // GET: CAT_TiposDeVialidad/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TiposDeVialidad cAT_TiposDeVialidad = db.CAT_TiposDeVialidad.Find(id);
            if (cAT_TiposDeVialidad == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TiposDeVialidad);
        }

        // GET: CAT_TiposDeVialidad/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_TiposDeVialidad/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdVialidad,NombreDeVialidad,Abreviatura")] CAT_TiposDeVialidad cAT_TiposDeVialidad)
        {
            if (ModelState.IsValid)
            {
                db.CAT_TiposDeVialidad.Add(cAT_TiposDeVialidad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_TiposDeVialidad);
        }

        // GET: CAT_TiposDeVialidad/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TiposDeVialidad cAT_TiposDeVialidad = db.CAT_TiposDeVialidad.Find(id);
            if (cAT_TiposDeVialidad == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TiposDeVialidad);
        }

        // POST: CAT_TiposDeVialidad/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdVialidad,NombreDeVialidad,Abreviatura")] CAT_TiposDeVialidad cAT_TiposDeVialidad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_TiposDeVialidad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_TiposDeVialidad);
        }

        // GET: CAT_TiposDeVialidad/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TiposDeVialidad cAT_TiposDeVialidad = db.CAT_TiposDeVialidad.Find(id);
            if (cAT_TiposDeVialidad == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TiposDeVialidad);
        }

        // POST: CAT_TiposDeVialidad/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_TiposDeVialidad cAT_TiposDeVialidad = db.CAT_TiposDeVialidad.Find(id);
            db.CAT_TiposDeVialidad.Remove(cAT_TiposDeVialidad);
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
