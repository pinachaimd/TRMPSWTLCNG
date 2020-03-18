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
    public class CAT_moduloController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_modulo
        public ActionResult Index()
        {
            var cAT_modulo = db.CAT_modulo.Include(c => c.CAT_sistema);
            return View(cAT_modulo.ToList());
        }

        // GET: CAT_modulo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_modulo cAT_modulo = db.CAT_modulo.Find(id);
            if (cAT_modulo == null)
            {
                return HttpNotFound();
            }
            return View(cAT_modulo);
        }

        // GET: CAT_modulo/Create
        public ActionResult Create()
        {
            ViewBag.idSistema = new SelectList(db.CAT_sistema, "id", "nombre");
            return View();
        }

        // POST: CAT_modulo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,idSistema,nombre")] CAT_modulo cAT_modulo)
        {
            if (ModelState.IsValid)
            {
                db.CAT_modulo.Add(cAT_modulo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idSistema = new SelectList(db.CAT_sistema, "id", "nombre", cAT_modulo.idSistema);
            return View(cAT_modulo);
        }

        // GET: CAT_modulo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_modulo cAT_modulo = db.CAT_modulo.Find(id);
            if (cAT_modulo == null)
            {
                return HttpNotFound();
            }
            ViewBag.idSistema = new SelectList(db.CAT_sistema, "id", "nombre", cAT_modulo.idSistema);
            return View(cAT_modulo);
        }

        // POST: CAT_modulo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idSistema,nombre")] CAT_modulo cAT_modulo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_modulo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idSistema = new SelectList(db.CAT_sistema, "id", "nombre", cAT_modulo.idSistema);
            return View(cAT_modulo);
        }

        // GET: CAT_modulo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_modulo cAT_modulo = db.CAT_modulo.Find(id);
            if (cAT_modulo == null)
            {
                return HttpNotFound();
            }
            return View(cAT_modulo);
        }

        // POST: CAT_modulo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_modulo cAT_modulo = db.CAT_modulo.Find(id);
            db.CAT_modulo.Remove(cAT_modulo);
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
