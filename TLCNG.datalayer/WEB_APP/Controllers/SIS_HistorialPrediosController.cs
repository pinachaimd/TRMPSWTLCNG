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
    public class SIS_HistorialPrediosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_HistorialPredios
        public ActionResult Index()
        {
            return View(db.SIS_HistorialPredios.ToList());
        }

        // GET: SIS_HistorialPredios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialPredios sIS_HistorialPredios = db.SIS_HistorialPredios.Find(id);
            if (sIS_HistorialPredios == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialPredios);
        }

        // GET: SIS_HistorialPredios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_HistorialPredios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,IdColoniaDePredio,IdTipoConstruccion,FechaAlta,FechaBaja,NombreCalle,NumeroExterior,NumeroInterior,CodigoPostal,UsuarioBaja,SuperficieDeTerreno,SuperficieDeConstruccion,SuperficieUrbana,SuperficiComercial,SuperficieIndustrial,ClaveCatastral,Municipio,Edificio,Ubicacion,IdTipoDeVialidad,ClaveOrigen,NumeroDeCuentaOrigen,ClaveCatastralOrigen,Descripcion,esCambio")] SIS_HistorialPredios sIS_HistorialPredios)
        {
            if (ModelState.IsValid)
            {
                db.SIS_HistorialPredios.Add(sIS_HistorialPredios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_HistorialPredios);
        }

        // GET: SIS_HistorialPredios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialPredios sIS_HistorialPredios = db.SIS_HistorialPredios.Find(id);
            if (sIS_HistorialPredios == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialPredios);
        }

        // POST: SIS_HistorialPredios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,IdColoniaDePredio,IdTipoConstruccion,FechaAlta,FechaBaja,NombreCalle,NumeroExterior,NumeroInterior,CodigoPostal,UsuarioBaja,SuperficieDeTerreno,SuperficieDeConstruccion,SuperficieUrbana,SuperficiComercial,SuperficieIndustrial,ClaveCatastral,Municipio,Edificio,Ubicacion,IdTipoDeVialidad,ClaveOrigen,NumeroDeCuentaOrigen,ClaveCatastralOrigen,Descripcion,esCambio")] SIS_HistorialPredios sIS_HistorialPredios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_HistorialPredios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_HistorialPredios);
        }

        // GET: SIS_HistorialPredios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialPredios sIS_HistorialPredios = db.SIS_HistorialPredios.Find(id);
            if (sIS_HistorialPredios == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialPredios);
        }

        // POST: SIS_HistorialPredios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_HistorialPredios sIS_HistorialPredios = db.SIS_HistorialPredios.Find(id);
            db.SIS_HistorialPredios.Remove(sIS_HistorialPredios);
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
