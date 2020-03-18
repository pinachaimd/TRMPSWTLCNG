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
    public class SIS_PrediosEjecucionController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_PrediosEjecucion
        public ActionResult Index()
        {
            return View(db.SIS_PrediosEjecucion.ToList());
        }

        // GET: SIS_PrediosEjecucion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_PrediosEjecucion sIS_PrediosEjecucion = db.SIS_PrediosEjecucion.Find(id);
            if (sIS_PrediosEjecucion == null)
            {
                return HttpNotFound();
            }
            return View(sIS_PrediosEjecucion);
        }

        // GET: SIS_PrediosEjecucion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_PrediosEjecucion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,IdColoniaDePredio,FechaAlta,NombreCalle,NumeroExterior,NumeroInterior,CodigoPostal,ClaveCatastral,Municipio,Edificio,Ubicacion,IdTipoDeVialidad,TipoOperacion,DescripcionOperacion,ClaveOrigen,NumeroDeCuentaOrigen,ClaveCatastralOrigen,Estatus,NumeroDeTramite")] SIS_PrediosEjecucion sIS_PrediosEjecucion)
        {
            if (ModelState.IsValid)
            {
                db.SIS_PrediosEjecucion.Add(sIS_PrediosEjecucion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_PrediosEjecucion);
        }

        // GET: SIS_PrediosEjecucion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_PrediosEjecucion sIS_PrediosEjecucion = db.SIS_PrediosEjecucion.Find(id);
            if (sIS_PrediosEjecucion == null)
            {
                return HttpNotFound();
            }
            return View(sIS_PrediosEjecucion);
        }

        // POST: SIS_PrediosEjecucion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,IdColoniaDePredio,FechaAlta,NombreCalle,NumeroExterior,NumeroInterior,CodigoPostal,ClaveCatastral,Municipio,Edificio,Ubicacion,IdTipoDeVialidad,TipoOperacion,DescripcionOperacion,ClaveOrigen,NumeroDeCuentaOrigen,ClaveCatastralOrigen,Estatus,NumeroDeTramite")] SIS_PrediosEjecucion sIS_PrediosEjecucion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_PrediosEjecucion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_PrediosEjecucion);
        }

        // GET: SIS_PrediosEjecucion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_PrediosEjecucion sIS_PrediosEjecucion = db.SIS_PrediosEjecucion.Find(id);
            if (sIS_PrediosEjecucion == null)
            {
                return HttpNotFound();
            }
            return View(sIS_PrediosEjecucion);
        }

        // POST: SIS_PrediosEjecucion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_PrediosEjecucion sIS_PrediosEjecucion = db.SIS_PrediosEjecucion.Find(id);
            db.SIS_PrediosEjecucion.Remove(sIS_PrediosEjecucion);
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
