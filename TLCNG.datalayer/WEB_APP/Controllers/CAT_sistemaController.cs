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
    public class CAT_sistemaController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_sistema
        public ActionResult Index()
        {
            return View(db.CAT_sistema.ToList());
        }

        // GET: CAT_sistema/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_sistema cAT_sistema = db.CAT_sistema.Find(id);
            if (cAT_sistema == null)
            {
                return HttpNotFound();
            }
            return View(cAT_sistema);
        }

        // GET: CAT_sistema/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_sistema/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre")] CAT_sistema cAT_sistema)
        {
            if (ModelState.IsValid)
            {
                db.CAT_sistema.Add(cAT_sistema);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_sistema);
        }

        // GET: CAT_sistema/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_sistema cAT_sistema = db.CAT_sistema.Find(id);
            if (cAT_sistema == null)
            {
                return HttpNotFound();
            }
            return View(cAT_sistema);
        }

        // POST: CAT_sistema/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre")] CAT_sistema cAT_sistema)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_sistema).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_sistema);
        }

        // GET: CAT_sistema/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_sistema cAT_sistema = db.CAT_sistema.Find(id);
            if (cAT_sistema == null)
            {
                return HttpNotFound();
            }
            return View(cAT_sistema);
        }

        // POST: CAT_sistema/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_sistema cAT_sistema = db.CAT_sistema.Find(id);
            db.CAT_sistema.Remove(cAT_sistema);
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
