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
    public class CANCELADO_SIS_PrediosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CANCELADO_SIS_Predios
        public ActionResult Index()
        {
            return View(db.CANCELADO_SIS_Predios.ToList());
        }

        // GET: CANCELADO_SIS_Predios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_Predios cANCELADO_SIS_Predios = db.CANCELADO_SIS_Predios.Find(id);
            if (cANCELADO_SIS_Predios == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_Predios);
        }

        // GET: CANCELADO_SIS_Predios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CANCELADO_SIS_Predios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,IdColoniaDePredio,FechaAlta,NombreCalle,NumeroExterior,NumeroInterior,CodigoPostal,ClaveCatastral,Municipio,Edificio,Ubicacion,IdTipoDeVialidad")] CANCELADO_SIS_Predios cANCELADO_SIS_Predios)
        {
            if (ModelState.IsValid)
            {
                db.CANCELADO_SIS_Predios.Add(cANCELADO_SIS_Predios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cANCELADO_SIS_Predios);
        }

        // GET: CANCELADO_SIS_Predios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_Predios cANCELADO_SIS_Predios = db.CANCELADO_SIS_Predios.Find(id);
            if (cANCELADO_SIS_Predios == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_Predios);
        }

        // POST: CANCELADO_SIS_Predios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,IdColoniaDePredio,FechaAlta,NombreCalle,NumeroExterior,NumeroInterior,CodigoPostal,ClaveCatastral,Municipio,Edificio,Ubicacion,IdTipoDeVialidad")] CANCELADO_SIS_Predios cANCELADO_SIS_Predios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cANCELADO_SIS_Predios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cANCELADO_SIS_Predios);
        }

        // GET: CANCELADO_SIS_Predios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_Predios cANCELADO_SIS_Predios = db.CANCELADO_SIS_Predios.Find(id);
            if (cANCELADO_SIS_Predios == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_Predios);
        }

        // POST: CANCELADO_SIS_Predios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CANCELADO_SIS_Predios cANCELADO_SIS_Predios = db.CANCELADO_SIS_Predios.Find(id);
            db.CANCELADO_SIS_Predios.Remove(cANCELADO_SIS_Predios);
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
