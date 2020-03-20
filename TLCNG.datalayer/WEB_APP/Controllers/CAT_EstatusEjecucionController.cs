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
    public class CAT_EstatusEjecucionController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_EstatusEjecucion
        public ActionResult Index()
        {
            return View(db.CAT_EstatusEjecucion.ToList());
        }

        // GET: CAT_EstatusEjecucion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_EstatusEjecucion cAT_EstatusEjecucion = db.CAT_EstatusEjecucion.Find(id);
            if (cAT_EstatusEjecucion == null)
            {
                return HttpNotFound();
            }
            return View(cAT_EstatusEjecucion);
        }

        // GET: CAT_EstatusEjecucion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_EstatusEjecucion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Proceso,Descripcion")] CAT_EstatusEjecucion cAT_EstatusEjecucion)
        {
            if (ModelState.IsValid)
            {
                db.CAT_EstatusEjecucion.Add(cAT_EstatusEjecucion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_EstatusEjecucion);
        }

        // GET: CAT_EstatusEjecucion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_EstatusEjecucion cAT_EstatusEjecucion = db.CAT_EstatusEjecucion.Find(id);
            if (cAT_EstatusEjecucion == null)
            {
                return HttpNotFound();
            }
            return View(cAT_EstatusEjecucion);
        }

        // POST: CAT_EstatusEjecucion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Proceso,Descripcion")] CAT_EstatusEjecucion cAT_EstatusEjecucion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_EstatusEjecucion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_EstatusEjecucion);
        }

        // GET: CAT_EstatusEjecucion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_EstatusEjecucion cAT_EstatusEjecucion = db.CAT_EstatusEjecucion.Find(id);
            if (cAT_EstatusEjecucion == null)
            {
                return HttpNotFound();
            }
            return View(cAT_EstatusEjecucion);
        }

        // POST: CAT_EstatusEjecucion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_EstatusEjecucion cAT_EstatusEjecucion = db.CAT_EstatusEjecucion.Find(id);
            db.CAT_EstatusEjecucion.Remove(cAT_EstatusEjecucion);
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
