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
    public class CAT_puestoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_puesto
        public ActionResult Index()
        {
            return View(db.CAT_puesto.ToList());
        }

        // GET: CAT_puesto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_puesto cAT_puesto = db.CAT_puesto.Find(id);
            if (cAT_puesto == null)
            {
                return HttpNotFound();
            }
            return View(cAT_puesto);
        }

        // GET: CAT_puesto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_puesto/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre")] CAT_puesto cAT_puesto)
        {
            if (ModelState.IsValid)
            {
                db.CAT_puesto.Add(cAT_puesto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_puesto);
        }

        // GET: CAT_puesto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_puesto cAT_puesto = db.CAT_puesto.Find(id);
            if (cAT_puesto == null)
            {
                return HttpNotFound();
            }
            return View(cAT_puesto);
        }

        // POST: CAT_puesto/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre")] CAT_puesto cAT_puesto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_puesto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_puesto);
        }

        // GET: CAT_puesto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_puesto cAT_puesto = db.CAT_puesto.Find(id);
            if (cAT_puesto == null)
            {
                return HttpNotFound();
            }
            return View(cAT_puesto);
        }

        // POST: CAT_puesto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_puesto cAT_puesto = db.CAT_puesto.Find(id);
            db.CAT_puesto.Remove(cAT_puesto);
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
