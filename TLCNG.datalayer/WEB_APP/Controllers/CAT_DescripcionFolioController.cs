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
    public class CAT_DescripcionFolioController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_DescripcionFolio
        public ActionResult Index()
        {
            return View(db.CAT_DescripcionFolio.ToList());
        }

        // GET: CAT_DescripcionFolio/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_DescripcionFolio cAT_DescripcionFolio = db.CAT_DescripcionFolio.Find(id);
            if (cAT_DescripcionFolio == null)
            {
                return HttpNotFound();
            }
            return View(cAT_DescripcionFolio);
        }

        // GET: CAT_DescripcionFolio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_DescripcionFolio/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descipcion")] CAT_DescripcionFolio cAT_DescripcionFolio)
        {
            if (ModelState.IsValid)
            {
                db.CAT_DescripcionFolio.Add(cAT_DescripcionFolio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_DescripcionFolio);
        }

        // GET: CAT_DescripcionFolio/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_DescripcionFolio cAT_DescripcionFolio = db.CAT_DescripcionFolio.Find(id);
            if (cAT_DescripcionFolio == null)
            {
                return HttpNotFound();
            }
            return View(cAT_DescripcionFolio);
        }

        // POST: CAT_DescripcionFolio/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descipcion")] CAT_DescripcionFolio cAT_DescripcionFolio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_DescripcionFolio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_DescripcionFolio);
        }

        // GET: CAT_DescripcionFolio/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_DescripcionFolio cAT_DescripcionFolio = db.CAT_DescripcionFolio.Find(id);
            if (cAT_DescripcionFolio == null)
            {
                return HttpNotFound();
            }
            return View(cAT_DescripcionFolio);
        }

        // POST: CAT_DescripcionFolio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_DescripcionFolio cAT_DescripcionFolio = db.CAT_DescripcionFolio.Find(id);
            db.CAT_DescripcionFolio.Remove(cAT_DescripcionFolio);
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
