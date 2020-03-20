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
    public class CAT_TipoConstruccionController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_TipoConstruccion
        public ActionResult Index()
        {
            return View(db.CAT_TipoConstruccion.ToList());
        }

        // GET: CAT_TipoConstruccion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoConstruccion cAT_TipoConstruccion = db.CAT_TipoConstruccion.Find(id);
            if (cAT_TipoConstruccion == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoConstruccion);
        }

        // GET: CAT_TipoConstruccion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_TipoConstruccion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NombreConstruccion")] CAT_TipoConstruccion cAT_TipoConstruccion)
        {
            if (ModelState.IsValid)
            {
                db.CAT_TipoConstruccion.Add(cAT_TipoConstruccion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_TipoConstruccion);
        }

        // GET: CAT_TipoConstruccion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoConstruccion cAT_TipoConstruccion = db.CAT_TipoConstruccion.Find(id);
            if (cAT_TipoConstruccion == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoConstruccion);
        }

        // POST: CAT_TipoConstruccion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NombreConstruccion")] CAT_TipoConstruccion cAT_TipoConstruccion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_TipoConstruccion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_TipoConstruccion);
        }

        // GET: CAT_TipoConstruccion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoConstruccion cAT_TipoConstruccion = db.CAT_TipoConstruccion.Find(id);
            if (cAT_TipoConstruccion == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoConstruccion);
        }

        // POST: CAT_TipoConstruccion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_TipoConstruccion cAT_TipoConstruccion = db.CAT_TipoConstruccion.Find(id);
            db.CAT_TipoConstruccion.Remove(cAT_TipoConstruccion);
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
