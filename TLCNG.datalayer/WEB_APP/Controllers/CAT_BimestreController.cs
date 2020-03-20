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
    public class CAT_BimestreController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_Bimestre
        public ActionResult Index()
        {
            return View(db.CAT_Bimestre.ToList());
        }

        // GET: CAT_Bimestre/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_Bimestre cAT_Bimestre = db.CAT_Bimestre.Find(id);
            if (cAT_Bimestre == null)
            {
                return HttpNotFound();
            }
            return View(cAT_Bimestre);
        }

        // GET: CAT_Bimestre/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_Bimestre/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NombreBimestre")] CAT_Bimestre cAT_Bimestre)
        {
            if (ModelState.IsValid)
            {
                db.CAT_Bimestre.Add(cAT_Bimestre);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_Bimestre);
        }

        // GET: CAT_Bimestre/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_Bimestre cAT_Bimestre = db.CAT_Bimestre.Find(id);
            if (cAT_Bimestre == null)
            {
                return HttpNotFound();
            }
            return View(cAT_Bimestre);
        }

        // POST: CAT_Bimestre/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NombreBimestre")] CAT_Bimestre cAT_Bimestre)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_Bimestre).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_Bimestre);
        }

        // GET: CAT_Bimestre/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_Bimestre cAT_Bimestre = db.CAT_Bimestre.Find(id);
            if (cAT_Bimestre == null)
            {
                return HttpNotFound();
            }
            return View(cAT_Bimestre);
        }

        // POST: CAT_Bimestre/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_Bimestre cAT_Bimestre = db.CAT_Bimestre.Find(id);
            db.CAT_Bimestre.Remove(cAT_Bimestre);
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
