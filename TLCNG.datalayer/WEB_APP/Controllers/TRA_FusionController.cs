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
    public class TRA_FusionController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: TRA_Fusion
        public ActionResult Index()
        {
            return View(db.TRA_Fusion.ToList());
        }

        // GET: TRA_Fusion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_Fusion tRA_Fusion = db.TRA_Fusion.Find(id);
            if (tRA_Fusion == null)
            {
                return HttpNotFound();
            }
            return View(tRA_Fusion);
        }

        // GET: TRA_Fusion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TRA_Fusion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ClaveOrigen,CuentaOrigen,ClaveDestino,CuentaDestino,NumeroTramite")] TRA_Fusion tRA_Fusion)
        {
            if (ModelState.IsValid)
            {
                db.TRA_Fusion.Add(tRA_Fusion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tRA_Fusion);
        }

        // GET: TRA_Fusion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_Fusion tRA_Fusion = db.TRA_Fusion.Find(id);
            if (tRA_Fusion == null)
            {
                return HttpNotFound();
            }
            return View(tRA_Fusion);
        }

        // POST: TRA_Fusion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ClaveOrigen,CuentaOrigen,ClaveDestino,CuentaDestino,NumeroTramite")] TRA_Fusion tRA_Fusion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tRA_Fusion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tRA_Fusion);
        }

        // GET: TRA_Fusion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_Fusion tRA_Fusion = db.TRA_Fusion.Find(id);
            if (tRA_Fusion == null)
            {
                return HttpNotFound();
            }
            return View(tRA_Fusion);
        }

        // POST: TRA_Fusion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TRA_Fusion tRA_Fusion = db.TRA_Fusion.Find(id);
            db.TRA_Fusion.Remove(tRA_Fusion);
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
