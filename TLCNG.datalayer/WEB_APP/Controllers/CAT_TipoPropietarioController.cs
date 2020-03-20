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
    public class CAT_TipoPropietarioController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_TipoPropietario
        public ActionResult Index()
        {
            return View(db.CAT_TipoPropietario.ToList());
        }

        // GET: CAT_TipoPropietario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoPropietario cAT_TipoPropietario = db.CAT_TipoPropietario.Find(id);
            if (cAT_TipoPropietario == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoPropietario);
        }

        // GET: CAT_TipoPropietario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_TipoPropietario/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Nombre")] CAT_TipoPropietario cAT_TipoPropietario)
        {
            if (ModelState.IsValid)
            {
                db.CAT_TipoPropietario.Add(cAT_TipoPropietario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_TipoPropietario);
        }

        // GET: CAT_TipoPropietario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoPropietario cAT_TipoPropietario = db.CAT_TipoPropietario.Find(id);
            if (cAT_TipoPropietario == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoPropietario);
        }

        // POST: CAT_TipoPropietario/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Nombre")] CAT_TipoPropietario cAT_TipoPropietario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_TipoPropietario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_TipoPropietario);
        }

        // GET: CAT_TipoPropietario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoPropietario cAT_TipoPropietario = db.CAT_TipoPropietario.Find(id);
            if (cAT_TipoPropietario == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoPropietario);
        }

        // POST: CAT_TipoPropietario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_TipoPropietario cAT_TipoPropietario = db.CAT_TipoPropietario.Find(id);
            db.CAT_TipoPropietario.Remove(cAT_TipoPropietario);
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
