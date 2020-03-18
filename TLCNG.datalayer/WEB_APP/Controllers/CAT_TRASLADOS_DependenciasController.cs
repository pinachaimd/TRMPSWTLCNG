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
    public class CAT_TRASLADOS_DependenciasController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_TRASLADOS_Dependencias
        public ActionResult Index()
        {
            return View(db.CAT_TRASLADOS_Dependencias.ToList());
        }

        // GET: CAT_TRASLADOS_Dependencias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TRASLADOS_Dependencias cAT_TRASLADOS_Dependencias = db.CAT_TRASLADOS_Dependencias.Find(id);
            if (cAT_TRASLADOS_Dependencias == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TRASLADOS_Dependencias);
        }

        // GET: CAT_TRASLADOS_Dependencias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_TRASLADOS_Dependencias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre,titularNombre,titularApellidoPaterno,titularApellidoMaterno")] CAT_TRASLADOS_Dependencias cAT_TRASLADOS_Dependencias)
        {
            if (ModelState.IsValid)
            {
                db.CAT_TRASLADOS_Dependencias.Add(cAT_TRASLADOS_Dependencias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_TRASLADOS_Dependencias);
        }

        // GET: CAT_TRASLADOS_Dependencias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TRASLADOS_Dependencias cAT_TRASLADOS_Dependencias = db.CAT_TRASLADOS_Dependencias.Find(id);
            if (cAT_TRASLADOS_Dependencias == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TRASLADOS_Dependencias);
        }

        // POST: CAT_TRASLADOS_Dependencias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre,titularNombre,titularApellidoPaterno,titularApellidoMaterno")] CAT_TRASLADOS_Dependencias cAT_TRASLADOS_Dependencias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_TRASLADOS_Dependencias).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_TRASLADOS_Dependencias);
        }

        // GET: CAT_TRASLADOS_Dependencias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TRASLADOS_Dependencias cAT_TRASLADOS_Dependencias = db.CAT_TRASLADOS_Dependencias.Find(id);
            if (cAT_TRASLADOS_Dependencias == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TRASLADOS_Dependencias);
        }

        // POST: CAT_TRASLADOS_Dependencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_TRASLADOS_Dependencias cAT_TRASLADOS_Dependencias = db.CAT_TRASLADOS_Dependencias.Find(id);
            db.CAT_TRASLADOS_Dependencias.Remove(cAT_TRASLADOS_Dependencias);
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
