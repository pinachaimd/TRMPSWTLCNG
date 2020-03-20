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
    public class CAT_TRASLADOS_EstatusFlujoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_TRASLADOS_EstatusFlujo
        public ActionResult Index()
        {
            return View(db.CAT_TRASLADOS_EstatusFlujo.ToList());
        }

        // GET: CAT_TRASLADOS_EstatusFlujo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TRASLADOS_EstatusFlujo cAT_TRASLADOS_EstatusFlujo = db.CAT_TRASLADOS_EstatusFlujo.Find(id);
            if (cAT_TRASLADOS_EstatusFlujo == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TRASLADOS_EstatusFlujo);
        }

        // GET: CAT_TRASLADOS_EstatusFlujo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_TRASLADOS_EstatusFlujo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,descripcion")] CAT_TRASLADOS_EstatusFlujo cAT_TRASLADOS_EstatusFlujo)
        {
            if (ModelState.IsValid)
            {
                db.CAT_TRASLADOS_EstatusFlujo.Add(cAT_TRASLADOS_EstatusFlujo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_TRASLADOS_EstatusFlujo);
        }

        // GET: CAT_TRASLADOS_EstatusFlujo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TRASLADOS_EstatusFlujo cAT_TRASLADOS_EstatusFlujo = db.CAT_TRASLADOS_EstatusFlujo.Find(id);
            if (cAT_TRASLADOS_EstatusFlujo == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TRASLADOS_EstatusFlujo);
        }

        // POST: CAT_TRASLADOS_EstatusFlujo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,descripcion")] CAT_TRASLADOS_EstatusFlujo cAT_TRASLADOS_EstatusFlujo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_TRASLADOS_EstatusFlujo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_TRASLADOS_EstatusFlujo);
        }

        // GET: CAT_TRASLADOS_EstatusFlujo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TRASLADOS_EstatusFlujo cAT_TRASLADOS_EstatusFlujo = db.CAT_TRASLADOS_EstatusFlujo.Find(id);
            if (cAT_TRASLADOS_EstatusFlujo == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TRASLADOS_EstatusFlujo);
        }

        // POST: CAT_TRASLADOS_EstatusFlujo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_TRASLADOS_EstatusFlujo cAT_TRASLADOS_EstatusFlujo = db.CAT_TRASLADOS_EstatusFlujo.Find(id);
            db.CAT_TRASLADOS_EstatusFlujo.Remove(cAT_TRASLADOS_EstatusFlujo);
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
