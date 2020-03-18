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
    public class SIS_ParametrosRecargoBimestralController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_ParametrosRecargoBimestral
        public ActionResult Index()
        {
            return View(db.SIS_ParametrosRecargoBimestral.ToList());
        }

        // GET: SIS_ParametrosRecargoBimestral/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_ParametrosRecargoBimestral sIS_ParametrosRecargoBimestral = db.SIS_ParametrosRecargoBimestral.Find(id);
            if (sIS_ParametrosRecargoBimestral == null)
            {
                return HttpNotFound();
            }
            return View(sIS_ParametrosRecargoBimestral);
        }

        // GET: SIS_ParametrosRecargoBimestral/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_ParametrosRecargoBimestral/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,año,idBimestre,aplicado,porcentaje")] SIS_ParametrosRecargoBimestral sIS_ParametrosRecargoBimestral)
        {
            if (ModelState.IsValid)
            {
                db.SIS_ParametrosRecargoBimestral.Add(sIS_ParametrosRecargoBimestral);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_ParametrosRecargoBimestral);
        }

        // GET: SIS_ParametrosRecargoBimestral/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_ParametrosRecargoBimestral sIS_ParametrosRecargoBimestral = db.SIS_ParametrosRecargoBimestral.Find(id);
            if (sIS_ParametrosRecargoBimestral == null)
            {
                return HttpNotFound();
            }
            return View(sIS_ParametrosRecargoBimestral);
        }

        // POST: SIS_ParametrosRecargoBimestral/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,año,idBimestre,aplicado,porcentaje")] SIS_ParametrosRecargoBimestral sIS_ParametrosRecargoBimestral)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_ParametrosRecargoBimestral).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_ParametrosRecargoBimestral);
        }

        // GET: SIS_ParametrosRecargoBimestral/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_ParametrosRecargoBimestral sIS_ParametrosRecargoBimestral = db.SIS_ParametrosRecargoBimestral.Find(id);
            if (sIS_ParametrosRecargoBimestral == null)
            {
                return HttpNotFound();
            }
            return View(sIS_ParametrosRecargoBimestral);
        }

        // POST: SIS_ParametrosRecargoBimestral/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_ParametrosRecargoBimestral sIS_ParametrosRecargoBimestral = db.SIS_ParametrosRecargoBimestral.Find(id);
            db.SIS_ParametrosRecargoBimestral.Remove(sIS_ParametrosRecargoBimestral);
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
