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
    public class CAT_ColoniaController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_Colonia
        public ActionResult Index()
        {
            return View(db.CAT_Colonia.ToList());
        }

        // GET: CAT_Colonia/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_Colonia cAT_Colonia = db.CAT_Colonia.Find(id);
            if (cAT_Colonia == null)
            {
                return HttpNotFound();
            }
            return View(cAT_Colonia);
        }

        // GET: CAT_Colonia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_Colonia/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdTipoColonia,ClaveColonia,Nombre,CodigoPostal,NombreLocalidad,IdLocalidad,NombreMunicipio,IdMunicipio,NombreEntidad,IdEntidad")] CAT_Colonia cAT_Colonia)
        {
            if (ModelState.IsValid)
            {
                db.CAT_Colonia.Add(cAT_Colonia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_Colonia);
        }

        // GET: CAT_Colonia/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_Colonia cAT_Colonia = db.CAT_Colonia.Find(id);
            if (cAT_Colonia == null)
            {
                return HttpNotFound();
            }
            return View(cAT_Colonia);
        }

        // POST: CAT_Colonia/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdTipoColonia,ClaveColonia,Nombre,CodigoPostal,NombreLocalidad,IdLocalidad,NombreMunicipio,IdMunicipio,NombreEntidad,IdEntidad")] CAT_Colonia cAT_Colonia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_Colonia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_Colonia);
        }

        // GET: CAT_Colonia/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_Colonia cAT_Colonia = db.CAT_Colonia.Find(id);
            if (cAT_Colonia == null)
            {
                return HttpNotFound();
            }
            return View(cAT_Colonia);
        }

        // POST: CAT_Colonia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_Colonia cAT_Colonia = db.CAT_Colonia.Find(id);
            db.CAT_Colonia.Remove(cAT_Colonia);
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
