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
    public class CAT_PersonaVulnerableController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_PersonaVulnerable
        public ActionResult Index()
        {
            return View(db.CAT_PersonaVulnerable.ToList());
        }

        // GET: CAT_PersonaVulnerable/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_PersonaVulnerable cAT_PersonaVulnerable = db.CAT_PersonaVulnerable.Find(id);
            if (cAT_PersonaVulnerable == null)
            {
                return HttpNotFound();
            }
            return View(cAT_PersonaVulnerable);
        }

        // GET: CAT_PersonaVulnerable/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_PersonaVulnerable/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,clave,descripcion")] CAT_PersonaVulnerable cAT_PersonaVulnerable)
        {
            if (ModelState.IsValid)
            {
                db.CAT_PersonaVulnerable.Add(cAT_PersonaVulnerable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_PersonaVulnerable);
        }

        // GET: CAT_PersonaVulnerable/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_PersonaVulnerable cAT_PersonaVulnerable = db.CAT_PersonaVulnerable.Find(id);
            if (cAT_PersonaVulnerable == null)
            {
                return HttpNotFound();
            }
            return View(cAT_PersonaVulnerable);
        }

        // POST: CAT_PersonaVulnerable/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,clave,descripcion")] CAT_PersonaVulnerable cAT_PersonaVulnerable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_PersonaVulnerable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_PersonaVulnerable);
        }

        // GET: CAT_PersonaVulnerable/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_PersonaVulnerable cAT_PersonaVulnerable = db.CAT_PersonaVulnerable.Find(id);
            if (cAT_PersonaVulnerable == null)
            {
                return HttpNotFound();
            }
            return View(cAT_PersonaVulnerable);
        }

        // POST: CAT_PersonaVulnerable/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_PersonaVulnerable cAT_PersonaVulnerable = db.CAT_PersonaVulnerable.Find(id);
            db.CAT_PersonaVulnerable.Remove(cAT_PersonaVulnerable);
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
