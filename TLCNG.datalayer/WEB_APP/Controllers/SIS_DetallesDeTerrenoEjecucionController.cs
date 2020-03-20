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
    public class SIS_DetallesDeTerrenoEjecucionController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_DetallesDeTerrenoEjecucion
        public ActionResult Index()
        {
            return View(db.SIS_DetallesDeTerrenoEjecucion.ToList());
        }

        // GET: SIS_DetallesDeTerrenoEjecucion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_DetallesDeTerrenoEjecucion sIS_DetallesDeTerrenoEjecucion = db.SIS_DetallesDeTerrenoEjecucion.Find(id);
            if (sIS_DetallesDeTerrenoEjecucion == null)
            {
                return HttpNotFound();
            }
            return View(sIS_DetallesDeTerrenoEjecucion);
        }

        // GET: SIS_DetallesDeTerrenoEjecucion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_DetallesDeTerrenoEjecucion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,AreaConstruccion,UsoDeSuelo,IdTipoDeConstruccion,Municipio,Edificio,TipoOperacion,DescripcionOperacion,ClaveOrigen,NumeroDeCuentaOrigen,ClaveCatastralOrigen,Estatus")] SIS_DetallesDeTerrenoEjecucion sIS_DetallesDeTerrenoEjecucion)
        {
            if (ModelState.IsValid)
            {
                db.SIS_DetallesDeTerrenoEjecucion.Add(sIS_DetallesDeTerrenoEjecucion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_DetallesDeTerrenoEjecucion);
        }

        // GET: SIS_DetallesDeTerrenoEjecucion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_DetallesDeTerrenoEjecucion sIS_DetallesDeTerrenoEjecucion = db.SIS_DetallesDeTerrenoEjecucion.Find(id);
            if (sIS_DetallesDeTerrenoEjecucion == null)
            {
                return HttpNotFound();
            }
            return View(sIS_DetallesDeTerrenoEjecucion);
        }

        // POST: SIS_DetallesDeTerrenoEjecucion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,AreaConstruccion,UsoDeSuelo,IdTipoDeConstruccion,Municipio,Edificio,TipoOperacion,DescripcionOperacion,ClaveOrigen,NumeroDeCuentaOrigen,ClaveCatastralOrigen,Estatus")] SIS_DetallesDeTerrenoEjecucion sIS_DetallesDeTerrenoEjecucion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_DetallesDeTerrenoEjecucion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_DetallesDeTerrenoEjecucion);
        }

        // GET: SIS_DetallesDeTerrenoEjecucion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_DetallesDeTerrenoEjecucion sIS_DetallesDeTerrenoEjecucion = db.SIS_DetallesDeTerrenoEjecucion.Find(id);
            if (sIS_DetallesDeTerrenoEjecucion == null)
            {
                return HttpNotFound();
            }
            return View(sIS_DetallesDeTerrenoEjecucion);
        }

        // POST: SIS_DetallesDeTerrenoEjecucion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_DetallesDeTerrenoEjecucion sIS_DetallesDeTerrenoEjecucion = db.SIS_DetallesDeTerrenoEjecucion.Find(id);
            db.SIS_DetallesDeTerrenoEjecucion.Remove(sIS_DetallesDeTerrenoEjecucion);
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
