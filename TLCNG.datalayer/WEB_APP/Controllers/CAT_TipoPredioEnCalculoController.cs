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
    public class CAT_TipoPredioEnCalculoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_TipoPredioEnCalculo
        public ActionResult Index()
        {
            return View(db.CAT_TipoPredioEnCalculo.ToList());
        }

        // GET: CAT_TipoPredioEnCalculo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoPredioEnCalculo cAT_TipoPredioEnCalculo = db.CAT_TipoPredioEnCalculo.Find(id);
            if (cAT_TipoPredioEnCalculo == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoPredioEnCalculo);
        }

        // GET: CAT_TipoPredioEnCalculo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_TipoPredioEnCalculo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TipoDePredio,Descripcion")] CAT_TipoPredioEnCalculo cAT_TipoPredioEnCalculo)
        {
            if (ModelState.IsValid)
            {
                db.CAT_TipoPredioEnCalculo.Add(cAT_TipoPredioEnCalculo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_TipoPredioEnCalculo);
        }

        // GET: CAT_TipoPredioEnCalculo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoPredioEnCalculo cAT_TipoPredioEnCalculo = db.CAT_TipoPredioEnCalculo.Find(id);
            if (cAT_TipoPredioEnCalculo == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoPredioEnCalculo);
        }

        // POST: CAT_TipoPredioEnCalculo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TipoDePredio,Descripcion")] CAT_TipoPredioEnCalculo cAT_TipoPredioEnCalculo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_TipoPredioEnCalculo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_TipoPredioEnCalculo);
        }

        // GET: CAT_TipoPredioEnCalculo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoPredioEnCalculo cAT_TipoPredioEnCalculo = db.CAT_TipoPredioEnCalculo.Find(id);
            if (cAT_TipoPredioEnCalculo == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoPredioEnCalculo);
        }

        // POST: CAT_TipoPredioEnCalculo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_TipoPredioEnCalculo cAT_TipoPredioEnCalculo = db.CAT_TipoPredioEnCalculo.Find(id);
            db.CAT_TipoPredioEnCalculo.Remove(cAT_TipoPredioEnCalculo);
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
