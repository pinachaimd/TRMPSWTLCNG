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
    public class CAT_Bimestre1Controller : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_Bimestre1
        public ActionResult Index()
        {
            return View(db.CAT_Bimestre1.ToList());
        }

        // GET: CAT_Bimestre1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_Bimestre1 cAT_Bimestre1 = db.CAT_Bimestre1.Find(id);
            if (cAT_Bimestre1 == null)
            {
                return HttpNotFound();
            }
            return View(cAT_Bimestre1);
        }

        // GET: CAT_Bimestre1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_Bimestre1/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdNomBim,NombreBimestre,Mes,IdActImpPre,MesAnterior")] CAT_Bimestre1 cAT_Bimestre1)
        {
            if (ModelState.IsValid)
            {
                db.CAT_Bimestre1.Add(cAT_Bimestre1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_Bimestre1);
        }

        // GET: CAT_Bimestre1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_Bimestre1 cAT_Bimestre1 = db.CAT_Bimestre1.Find(id);
            if (cAT_Bimestre1 == null)
            {
                return HttpNotFound();
            }
            return View(cAT_Bimestre1);
        }

        // POST: CAT_Bimestre1/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdNomBim,NombreBimestre,Mes,IdActImpPre,MesAnterior")] CAT_Bimestre1 cAT_Bimestre1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_Bimestre1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_Bimestre1);
        }

        // GET: CAT_Bimestre1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_Bimestre1 cAT_Bimestre1 = db.CAT_Bimestre1.Find(id);
            if (cAT_Bimestre1 == null)
            {
                return HttpNotFound();
            }
            return View(cAT_Bimestre1);
        }

        // POST: CAT_Bimestre1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_Bimestre1 cAT_Bimestre1 = db.CAT_Bimestre1.Find(id);
            db.CAT_Bimestre1.Remove(cAT_Bimestre1);
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
