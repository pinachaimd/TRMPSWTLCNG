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
    public class CAT_DirectorController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_Director
        public ActionResult Index()
        {
            return View(db.CAT_Director.ToList());
        }

        // GET: CAT_Director/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_Director cAT_Director = db.CAT_Director.Find(id);
            if (cAT_Director == null)
            {
                return HttpNotFound();
            }
            return View(cAT_Director);
        }

        // GET: CAT_Director/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_Director/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdDirector,Siglas,NomDirector,ApePDirector,ApeMDirector,Nombre")] CAT_Director cAT_Director)
        {
            if (ModelState.IsValid)
            {
                db.CAT_Director.Add(cAT_Director);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_Director);
        }

        // GET: CAT_Director/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_Director cAT_Director = db.CAT_Director.Find(id);
            if (cAT_Director == null)
            {
                return HttpNotFound();
            }
            return View(cAT_Director);
        }

        // POST: CAT_Director/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdDirector,Siglas,NomDirector,ApePDirector,ApeMDirector,Nombre")] CAT_Director cAT_Director)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_Director).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_Director);
        }

        // GET: CAT_Director/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_Director cAT_Director = db.CAT_Director.Find(id);
            if (cAT_Director == null)
            {
                return HttpNotFound();
            }
            return View(cAT_Director);
        }

        // POST: CAT_Director/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_Director cAT_Director = db.CAT_Director.Find(id);
            db.CAT_Director.Remove(cAT_Director);
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
