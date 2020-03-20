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
    public class SIS_HistorialDetallesDeTerrenoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_HistorialDetallesDeTerreno
        public ActionResult Index()
        {
            return View(db.SIS_HistorialDetallesDeTerreno.ToList());
        }

        // GET: SIS_HistorialDetallesDeTerreno/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialDetallesDeTerreno sIS_HistorialDetallesDeTerreno = db.SIS_HistorialDetallesDeTerreno.Find(id);
            if (sIS_HistorialDetallesDeTerreno == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialDetallesDeTerreno);
        }

        // GET: SIS_HistorialDetallesDeTerreno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_HistorialDetallesDeTerreno/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,AreaConstruccion,UsoDeSuelo,IdTipoDeConstruccion,Municipio,Edificio,ClaveOrigen,NumeroDeCuentaOrigen")] SIS_HistorialDetallesDeTerreno sIS_HistorialDetallesDeTerreno)
        {
            if (ModelState.IsValid)
            {
                db.SIS_HistorialDetallesDeTerreno.Add(sIS_HistorialDetallesDeTerreno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_HistorialDetallesDeTerreno);
        }

        // GET: SIS_HistorialDetallesDeTerreno/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialDetallesDeTerreno sIS_HistorialDetallesDeTerreno = db.SIS_HistorialDetallesDeTerreno.Find(id);
            if (sIS_HistorialDetallesDeTerreno == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialDetallesDeTerreno);
        }

        // POST: SIS_HistorialDetallesDeTerreno/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,AreaConstruccion,UsoDeSuelo,IdTipoDeConstruccion,Municipio,Edificio,ClaveOrigen,NumeroDeCuentaOrigen")] SIS_HistorialDetallesDeTerreno sIS_HistorialDetallesDeTerreno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_HistorialDetallesDeTerreno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_HistorialDetallesDeTerreno);
        }

        // GET: SIS_HistorialDetallesDeTerreno/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialDetallesDeTerreno sIS_HistorialDetallesDeTerreno = db.SIS_HistorialDetallesDeTerreno.Find(id);
            if (sIS_HistorialDetallesDeTerreno == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialDetallesDeTerreno);
        }

        // POST: SIS_HistorialDetallesDeTerreno/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_HistorialDetallesDeTerreno sIS_HistorialDetallesDeTerreno = db.SIS_HistorialDetallesDeTerreno.Find(id);
            db.SIS_HistorialDetallesDeTerreno.Remove(sIS_HistorialDetallesDeTerreno);
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
