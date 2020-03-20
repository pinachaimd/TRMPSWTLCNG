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
    public class SIS_PrediosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_Predios
        public ActionResult Index()
        {
            return View(db.SIS_Predios.ToList());
        }

        // GET: SIS_Predios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_Predios sIS_Predios = db.SIS_Predios.Find(id);
            if (sIS_Predios == null)
            {
                return HttpNotFound();
            }
            return View(sIS_Predios);
        }

        // GET: SIS_Predios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_Predios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,IdColoniaDePredio,FechaAlta,NombreCalle,NumeroExterior,NumeroInterior,CodigoPostal,ClaveCatastral,Municipio,Edificio,Ubicacion,IdTipoDeVialidad,column_CuentaPredial")] SIS_Predios sIS_Predios)
        {
            if (ModelState.IsValid)
            {
                db.SIS_Predios.Add(sIS_Predios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_Predios);
        }

        // GET: SIS_Predios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_Predios sIS_Predios = db.SIS_Predios.Find(id);
            if (sIS_Predios == null)
            {
                return HttpNotFound();
            }
            return View(sIS_Predios);
        }

        // POST: SIS_Predios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,IdColoniaDePredio,FechaAlta,NombreCalle,NumeroExterior,NumeroInterior,CodigoPostal,ClaveCatastral,Municipio,Edificio,Ubicacion,IdTipoDeVialidad,column_CuentaPredial")] SIS_Predios sIS_Predios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_Predios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_Predios);
        }

        // GET: SIS_Predios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_Predios sIS_Predios = db.SIS_Predios.Find(id);
            if (sIS_Predios == null)
            {
                return HttpNotFound();
            }
            return View(sIS_Predios);
        }

        // POST: SIS_Predios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_Predios sIS_Predios = db.SIS_Predios.Find(id);
            db.SIS_Predios.Remove(sIS_Predios);
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
