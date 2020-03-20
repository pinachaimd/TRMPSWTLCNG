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
    public class CAT_UbicacionCajasController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_UbicacionCajas
        public ActionResult Index()
        {
            return View(db.CAT_UbicacionCajas.ToList());
        }

        // GET: CAT_UbicacionCajas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_UbicacionCajas cAT_UbicacionCajas = db.CAT_UbicacionCajas.Find(id);
            if (cAT_UbicacionCajas == null)
            {
                return HttpNotFound();
            }
            return View(cAT_UbicacionCajas);
        }

        // GET: CAT_UbicacionCajas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_UbicacionCajas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombreUbicacionCaja")] CAT_UbicacionCajas cAT_UbicacionCajas)
        {
            if (ModelState.IsValid)
            {
                db.CAT_UbicacionCajas.Add(cAT_UbicacionCajas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_UbicacionCajas);
        }

        // GET: CAT_UbicacionCajas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_UbicacionCajas cAT_UbicacionCajas = db.CAT_UbicacionCajas.Find(id);
            if (cAT_UbicacionCajas == null)
            {
                return HttpNotFound();
            }
            return View(cAT_UbicacionCajas);
        }

        // POST: CAT_UbicacionCajas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombreUbicacionCaja")] CAT_UbicacionCajas cAT_UbicacionCajas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_UbicacionCajas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_UbicacionCajas);
        }

        // GET: CAT_UbicacionCajas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_UbicacionCajas cAT_UbicacionCajas = db.CAT_UbicacionCajas.Find(id);
            if (cAT_UbicacionCajas == null)
            {
                return HttpNotFound();
            }
            return View(cAT_UbicacionCajas);
        }

        // POST: CAT_UbicacionCajas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_UbicacionCajas cAT_UbicacionCajas = db.CAT_UbicacionCajas.Find(id);
            db.CAT_UbicacionCajas.Remove(cAT_UbicacionCajas);
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
