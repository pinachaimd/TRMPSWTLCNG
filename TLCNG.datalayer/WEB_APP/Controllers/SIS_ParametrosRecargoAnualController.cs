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
    public class SIS_ParametrosRecargoAnualController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_ParametrosRecargoAnual
        public ActionResult Index()
        {
            return View(db.SIS_ParametrosRecargoAnual.ToList());
        }

        // GET: SIS_ParametrosRecargoAnual/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_ParametrosRecargoAnual sIS_ParametrosRecargoAnual = db.SIS_ParametrosRecargoAnual.Find(id);
            if (sIS_ParametrosRecargoAnual == null)
            {
                return HttpNotFound();
            }
            return View(sIS_ParametrosRecargoAnual);
        }

        // GET: SIS_ParametrosRecargoAnual/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_ParametrosRecargoAnual/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,idTipoDePredio,año,porcentageImpuestoPredialBG,tasaAnual")] SIS_ParametrosRecargoAnual sIS_ParametrosRecargoAnual)
        {
            if (ModelState.IsValid)
            {
                db.SIS_ParametrosRecargoAnual.Add(sIS_ParametrosRecargoAnual);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_ParametrosRecargoAnual);
        }

        // GET: SIS_ParametrosRecargoAnual/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_ParametrosRecargoAnual sIS_ParametrosRecargoAnual = db.SIS_ParametrosRecargoAnual.Find(id);
            if (sIS_ParametrosRecargoAnual == null)
            {
                return HttpNotFound();
            }
            return View(sIS_ParametrosRecargoAnual);
        }

        // POST: SIS_ParametrosRecargoAnual/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,idTipoDePredio,año,porcentageImpuestoPredialBG,tasaAnual")] SIS_ParametrosRecargoAnual sIS_ParametrosRecargoAnual)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_ParametrosRecargoAnual).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_ParametrosRecargoAnual);
        }

        // GET: SIS_ParametrosRecargoAnual/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_ParametrosRecargoAnual sIS_ParametrosRecargoAnual = db.SIS_ParametrosRecargoAnual.Find(id);
            if (sIS_ParametrosRecargoAnual == null)
            {
                return HttpNotFound();
            }
            return View(sIS_ParametrosRecargoAnual);
        }

        // POST: SIS_ParametrosRecargoAnual/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_ParametrosRecargoAnual sIS_ParametrosRecargoAnual = db.SIS_ParametrosRecargoAnual.Find(id);
            db.SIS_ParametrosRecargoAnual.Remove(sIS_ParametrosRecargoAnual);
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
