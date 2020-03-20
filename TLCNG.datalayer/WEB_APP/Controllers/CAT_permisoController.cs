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
    public class CAT_permisoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_permiso
        public ActionResult Index()
        {
            var cAT_permiso = db.CAT_permiso.Include(c => c.CAT_nombrePermiso).Include(c => c.CAT_perfil);
            return View(cAT_permiso.ToList());
        }

        // GET: CAT_permiso/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_permiso cAT_permiso = db.CAT_permiso.Find(id);
            if (cAT_permiso == null)
            {
                return HttpNotFound();
            }
            return View(cAT_permiso);
        }

        // GET: CAT_permiso/Create
        public ActionResult Create()
        {
            ViewBag.idNombrePermiso = new SelectList(db.CAT_nombrePermiso, "id", "nombre");
            ViewBag.idPerfil = new SelectList(db.CAT_perfil, "id", "nombre");
            return View();
        }

        // POST: CAT_permiso/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,idPerfil,idNombrePermiso,estatus,idUsuarios")] CAT_permiso cAT_permiso)
        {
            if (ModelState.IsValid)
            {
                db.CAT_permiso.Add(cAT_permiso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idNombrePermiso = new SelectList(db.CAT_nombrePermiso, "id", "nombre", cAT_permiso.idNombrePermiso);
            ViewBag.idPerfil = new SelectList(db.CAT_perfil, "id", "nombre", cAT_permiso.idPerfil);
            return View(cAT_permiso);
        }

        // GET: CAT_permiso/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_permiso cAT_permiso = db.CAT_permiso.Find(id);
            if (cAT_permiso == null)
            {
                return HttpNotFound();
            }
            ViewBag.idNombrePermiso = new SelectList(db.CAT_nombrePermiso, "id", "nombre", cAT_permiso.idNombrePermiso);
            ViewBag.idPerfil = new SelectList(db.CAT_perfil, "id", "nombre", cAT_permiso.idPerfil);
            return View(cAT_permiso);
        }

        // POST: CAT_permiso/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idPerfil,idNombrePermiso,estatus,idUsuarios")] CAT_permiso cAT_permiso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_permiso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idNombrePermiso = new SelectList(db.CAT_nombrePermiso, "id", "nombre", cAT_permiso.idNombrePermiso);
            ViewBag.idPerfil = new SelectList(db.CAT_perfil, "id", "nombre", cAT_permiso.idPerfil);
            return View(cAT_permiso);
        }

        // GET: CAT_permiso/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_permiso cAT_permiso = db.CAT_permiso.Find(id);
            if (cAT_permiso == null)
            {
                return HttpNotFound();
            }
            return View(cAT_permiso);
        }

        // POST: CAT_permiso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_permiso cAT_permiso = db.CAT_permiso.Find(id);
            db.CAT_permiso.Remove(cAT_permiso);
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
