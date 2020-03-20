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
    public class CAT_TipoCambioController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_TipoCambio
        public ActionResult Index()
        {
            return View(db.CAT_TipoCambio.ToList());
        }

        // GET: CAT_TipoCambio/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoCambio cAT_TipoCambio = db.CAT_TipoCambio.Find(id);
            if (cAT_TipoCambio == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoCambio);
        }

        // GET: CAT_TipoCambio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_TipoCambio/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NombreTipoCambio")] CAT_TipoCambio cAT_TipoCambio)
        {
            if (ModelState.IsValid)
            {
                db.CAT_TipoCambio.Add(cAT_TipoCambio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_TipoCambio);
        }

        // GET: CAT_TipoCambio/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoCambio cAT_TipoCambio = db.CAT_TipoCambio.Find(id);
            if (cAT_TipoCambio == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoCambio);
        }

        // POST: CAT_TipoCambio/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NombreTipoCambio")] CAT_TipoCambio cAT_TipoCambio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_TipoCambio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_TipoCambio);
        }

        // GET: CAT_TipoCambio/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoCambio cAT_TipoCambio = db.CAT_TipoCambio.Find(id);
            if (cAT_TipoCambio == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoCambio);
        }

        // POST: CAT_TipoCambio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_TipoCambio cAT_TipoCambio = db.CAT_TipoCambio.Find(id);
            db.CAT_TipoCambio.Remove(cAT_TipoCambio);
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
