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
    public class CAT_TipoPredioEnCalculo1Controller : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_TipoPredioEnCalculo1
        public ActionResult Index()
        {
            return View(db.CAT_TipoPredioEnCalculo1.ToList());
        }

        // GET: CAT_TipoPredioEnCalculo1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoPredioEnCalculo1 cAT_TipoPredioEnCalculo1 = db.CAT_TipoPredioEnCalculo1.Find(id);
            if (cAT_TipoPredioEnCalculo1 == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoPredioEnCalculo1);
        }

        // GET: CAT_TipoPredioEnCalculo1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_TipoPredioEnCalculo1/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TipoDePredio,Descripcion,Descripcion1,Descripcion2,Descripcion3,Valor")] CAT_TipoPredioEnCalculo1 cAT_TipoPredioEnCalculo1)
        {
            if (ModelState.IsValid)
            {
                db.CAT_TipoPredioEnCalculo1.Add(cAT_TipoPredioEnCalculo1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_TipoPredioEnCalculo1);
        }

        // GET: CAT_TipoPredioEnCalculo1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoPredioEnCalculo1 cAT_TipoPredioEnCalculo1 = db.CAT_TipoPredioEnCalculo1.Find(id);
            if (cAT_TipoPredioEnCalculo1 == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoPredioEnCalculo1);
        }

        // POST: CAT_TipoPredioEnCalculo1/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TipoDePredio,Descripcion,Descripcion1,Descripcion2,Descripcion3,Valor")] CAT_TipoPredioEnCalculo1 cAT_TipoPredioEnCalculo1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_TipoPredioEnCalculo1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_TipoPredioEnCalculo1);
        }

        // GET: CAT_TipoPredioEnCalculo1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoPredioEnCalculo1 cAT_TipoPredioEnCalculo1 = db.CAT_TipoPredioEnCalculo1.Find(id);
            if (cAT_TipoPredioEnCalculo1 == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoPredioEnCalculo1);
        }

        // POST: CAT_TipoPredioEnCalculo1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_TipoPredioEnCalculo1 cAT_TipoPredioEnCalculo1 = db.CAT_TipoPredioEnCalculo1.Find(id);
            db.CAT_TipoPredioEnCalculo1.Remove(cAT_TipoPredioEnCalculo1);
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
