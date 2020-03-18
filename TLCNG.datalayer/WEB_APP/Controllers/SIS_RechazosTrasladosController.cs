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
    public class SIS_RechazosTrasladosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_RechazosTraslados
        public ActionResult Index()
        {
            return View(db.SIS_RechazosTraslados.ToList());
        }

        // GET: SIS_RechazosTraslados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_RechazosTraslados sIS_RechazosTraslados = db.SIS_RechazosTraslados.Find(id);
            if (sIS_RechazosTraslados == null)
            {
                return HttpNotFound();
            }
            return View(sIS_RechazosTraslados);
        }

        // GET: SIS_RechazosTraslados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_RechazosTraslados/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdRechazo,Clave,ClaveCatastral,NumeroDeCuenta,ClaveOrigen,NumeroDeCuentaOrigen,ClaveCatastralOrigen,Estatus,Tarea,NumeroTramite")] SIS_RechazosTraslados sIS_RechazosTraslados)
        {
            if (ModelState.IsValid)
            {
                db.SIS_RechazosTraslados.Add(sIS_RechazosTraslados);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_RechazosTraslados);
        }

        // GET: SIS_RechazosTraslados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_RechazosTraslados sIS_RechazosTraslados = db.SIS_RechazosTraslados.Find(id);
            if (sIS_RechazosTraslados == null)
            {
                return HttpNotFound();
            }
            return View(sIS_RechazosTraslados);
        }

        // POST: SIS_RechazosTraslados/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdRechazo,Clave,ClaveCatastral,NumeroDeCuenta,ClaveOrigen,NumeroDeCuentaOrigen,ClaveCatastralOrigen,Estatus,Tarea,NumeroTramite")] SIS_RechazosTraslados sIS_RechazosTraslados)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_RechazosTraslados).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_RechazosTraslados);
        }

        // GET: SIS_RechazosTraslados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_RechazosTraslados sIS_RechazosTraslados = db.SIS_RechazosTraslados.Find(id);
            if (sIS_RechazosTraslados == null)
            {
                return HttpNotFound();
            }
            return View(sIS_RechazosTraslados);
        }

        // POST: SIS_RechazosTraslados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_RechazosTraslados sIS_RechazosTraslados = db.SIS_RechazosTraslados.Find(id);
            db.SIS_RechazosTraslados.Remove(sIS_RechazosTraslados);
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
