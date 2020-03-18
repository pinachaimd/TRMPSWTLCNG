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
    public class CAT_nombrePermisoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_nombrePermiso
        public ActionResult Index()
        {
            var cAT_nombrePermiso = db.CAT_nombrePermiso.Include(c => c.CAT_modulo);
            return View(cAT_nombrePermiso.ToList());
        }

        // GET: CAT_nombrePermiso/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_nombrePermiso cAT_nombrePermiso = db.CAT_nombrePermiso.Find(id);
            if (cAT_nombrePermiso == null)
            {
                return HttpNotFound();
            }
            return View(cAT_nombrePermiso);
        }

        // GET: CAT_nombrePermiso/Create
        public ActionResult Create()
        {
            ViewBag.idModulo = new SelectList(db.CAT_modulo, "id", "nombre");
            return View();
        }

        // POST: CAT_nombrePermiso/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,idModulo,nombre")] CAT_nombrePermiso cAT_nombrePermiso)
        {
            if (ModelState.IsValid)
            {
                db.CAT_nombrePermiso.Add(cAT_nombrePermiso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idModulo = new SelectList(db.CAT_modulo, "id", "nombre", cAT_nombrePermiso.idModulo);
            return View(cAT_nombrePermiso);
        }

        // GET: CAT_nombrePermiso/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_nombrePermiso cAT_nombrePermiso = db.CAT_nombrePermiso.Find(id);
            if (cAT_nombrePermiso == null)
            {
                return HttpNotFound();
            }
            ViewBag.idModulo = new SelectList(db.CAT_modulo, "id", "nombre", cAT_nombrePermiso.idModulo);
            return View(cAT_nombrePermiso);
        }

        // POST: CAT_nombrePermiso/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idModulo,nombre")] CAT_nombrePermiso cAT_nombrePermiso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_nombrePermiso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idModulo = new SelectList(db.CAT_modulo, "id", "nombre", cAT_nombrePermiso.idModulo);
            return View(cAT_nombrePermiso);
        }

        // GET: CAT_nombrePermiso/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_nombrePermiso cAT_nombrePermiso = db.CAT_nombrePermiso.Find(id);
            if (cAT_nombrePermiso == null)
            {
                return HttpNotFound();
            }
            return View(cAT_nombrePermiso);
        }

        // POST: CAT_nombrePermiso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_nombrePermiso cAT_nombrePermiso = db.CAT_nombrePermiso.Find(id);
            db.CAT_nombrePermiso.Remove(cAT_nombrePermiso);
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
