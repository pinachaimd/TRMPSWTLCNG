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
    public class SIS_PermisosEspecialesController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_PermisosEspeciales
        public ActionResult Index()
        {
            return View(db.SIS_PermisosEspeciales.ToList());
        }

        // GET: SIS_PermisosEspeciales/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_PermisosEspeciales sIS_PermisosEspeciales = db.SIS_PermisosEspeciales.Find(id);
            if (sIS_PermisosEspeciales == null)
            {
                return HttpNotFound();
            }
            return View(sIS_PermisosEspeciales);
        }

        // GET: SIS_PermisosEspeciales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_PermisosEspeciales/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NombrePermiso,Activo")] SIS_PermisosEspeciales sIS_PermisosEspeciales)
        {
            if (ModelState.IsValid)
            {
                db.SIS_PermisosEspeciales.Add(sIS_PermisosEspeciales);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_PermisosEspeciales);
        }

        // GET: SIS_PermisosEspeciales/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_PermisosEspeciales sIS_PermisosEspeciales = db.SIS_PermisosEspeciales.Find(id);
            if (sIS_PermisosEspeciales == null)
            {
                return HttpNotFound();
            }
            return View(sIS_PermisosEspeciales);
        }

        // POST: SIS_PermisosEspeciales/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NombrePermiso,Activo")] SIS_PermisosEspeciales sIS_PermisosEspeciales)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_PermisosEspeciales).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_PermisosEspeciales);
        }

        // GET: SIS_PermisosEspeciales/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_PermisosEspeciales sIS_PermisosEspeciales = db.SIS_PermisosEspeciales.Find(id);
            if (sIS_PermisosEspeciales == null)
            {
                return HttpNotFound();
            }
            return View(sIS_PermisosEspeciales);
        }

        // POST: SIS_PermisosEspeciales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_PermisosEspeciales sIS_PermisosEspeciales = db.SIS_PermisosEspeciales.Find(id);
            db.SIS_PermisosEspeciales.Remove(sIS_PermisosEspeciales);
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
