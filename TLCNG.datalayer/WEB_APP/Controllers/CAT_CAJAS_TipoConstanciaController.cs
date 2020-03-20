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
    public class CAT_CAJAS_TipoConstanciaController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_CAJAS_TipoConstancia
        public ActionResult Index()
        {
            return View(db.CAT_CAJAS_TipoConstancia.ToList());
        }

        // GET: CAT_CAJAS_TipoConstancia/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_CAJAS_TipoConstancia cAT_CAJAS_TipoConstancia = db.CAT_CAJAS_TipoConstancia.Find(id);
            if (cAT_CAJAS_TipoConstancia == null)
            {
                return HttpNotFound();
            }
            return View(cAT_CAJAS_TipoConstancia);
        }

        // GET: CAT_CAJAS_TipoConstancia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_CAJAS_TipoConstancia/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NombreConstancia,costo,descripicion,fechaAlta,fechaModificacion")] CAT_CAJAS_TipoConstancia cAT_CAJAS_TipoConstancia)
        {
            if (ModelState.IsValid)
            {
                db.CAT_CAJAS_TipoConstancia.Add(cAT_CAJAS_TipoConstancia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_CAJAS_TipoConstancia);
        }

        // GET: CAT_CAJAS_TipoConstancia/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_CAJAS_TipoConstancia cAT_CAJAS_TipoConstancia = db.CAT_CAJAS_TipoConstancia.Find(id);
            if (cAT_CAJAS_TipoConstancia == null)
            {
                return HttpNotFound();
            }
            return View(cAT_CAJAS_TipoConstancia);
        }

        // POST: CAT_CAJAS_TipoConstancia/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NombreConstancia,costo,descripicion,fechaAlta,fechaModificacion")] CAT_CAJAS_TipoConstancia cAT_CAJAS_TipoConstancia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_CAJAS_TipoConstancia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_CAJAS_TipoConstancia);
        }

        // GET: CAT_CAJAS_TipoConstancia/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_CAJAS_TipoConstancia cAT_CAJAS_TipoConstancia = db.CAT_CAJAS_TipoConstancia.Find(id);
            if (cAT_CAJAS_TipoConstancia == null)
            {
                return HttpNotFound();
            }
            return View(cAT_CAJAS_TipoConstancia);
        }

        // POST: CAT_CAJAS_TipoConstancia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_CAJAS_TipoConstancia cAT_CAJAS_TipoConstancia = db.CAT_CAJAS_TipoConstancia.Find(id);
            db.CAT_CAJAS_TipoConstancia.Remove(cAT_CAJAS_TipoConstancia);
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
