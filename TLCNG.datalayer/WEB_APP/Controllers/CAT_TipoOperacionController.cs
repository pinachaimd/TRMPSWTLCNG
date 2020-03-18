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
    public class CAT_TipoOperacionController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_TipoOperacion
        public ActionResult Index()
        {
            return View(db.CAT_TipoOperacion.ToList());
        }

        // GET: CAT_TipoOperacion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoOperacion cAT_TipoOperacion = db.CAT_TipoOperacion.Find(id);
            if (cAT_TipoOperacion == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoOperacion);
        }

        // GET: CAT_TipoOperacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_TipoOperacion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NombreOperación")] CAT_TipoOperacion cAT_TipoOperacion)
        {
            if (ModelState.IsValid)
            {
                db.CAT_TipoOperacion.Add(cAT_TipoOperacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_TipoOperacion);
        }

        // GET: CAT_TipoOperacion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoOperacion cAT_TipoOperacion = db.CAT_TipoOperacion.Find(id);
            if (cAT_TipoOperacion == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoOperacion);
        }

        // POST: CAT_TipoOperacion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NombreOperación")] CAT_TipoOperacion cAT_TipoOperacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_TipoOperacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_TipoOperacion);
        }

        // GET: CAT_TipoOperacion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoOperacion cAT_TipoOperacion = db.CAT_TipoOperacion.Find(id);
            if (cAT_TipoOperacion == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoOperacion);
        }

        // POST: CAT_TipoOperacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_TipoOperacion cAT_TipoOperacion = db.CAT_TipoOperacion.Find(id);
            db.CAT_TipoOperacion.Remove(cAT_TipoOperacion);
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
