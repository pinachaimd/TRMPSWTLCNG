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
    public class CANCELADO_SIS_DetallesDeTerrenoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CANCELADO_SIS_DetallesDeTerreno
        public ActionResult Index()
        {
            return View(db.CANCELADO_SIS_DetallesDeTerreno.ToList());
        }

        // GET: CANCELADO_SIS_DetallesDeTerreno/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_DetallesDeTerreno cANCELADO_SIS_DetallesDeTerreno = db.CANCELADO_SIS_DetallesDeTerreno.Find(id);
            if (cANCELADO_SIS_DetallesDeTerreno == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_DetallesDeTerreno);
        }

        // GET: CANCELADO_SIS_DetallesDeTerreno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CANCELADO_SIS_DetallesDeTerreno/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,AreaConstruccion,UsoDeSuelo,IdTipoDeConstruccion,Municipio,Edificio")] CANCELADO_SIS_DetallesDeTerreno cANCELADO_SIS_DetallesDeTerreno)
        {
            if (ModelState.IsValid)
            {
                db.CANCELADO_SIS_DetallesDeTerreno.Add(cANCELADO_SIS_DetallesDeTerreno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cANCELADO_SIS_DetallesDeTerreno);
        }

        // GET: CANCELADO_SIS_DetallesDeTerreno/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_DetallesDeTerreno cANCELADO_SIS_DetallesDeTerreno = db.CANCELADO_SIS_DetallesDeTerreno.Find(id);
            if (cANCELADO_SIS_DetallesDeTerreno == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_DetallesDeTerreno);
        }

        // POST: CANCELADO_SIS_DetallesDeTerreno/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,AreaConstruccion,UsoDeSuelo,IdTipoDeConstruccion,Municipio,Edificio")] CANCELADO_SIS_DetallesDeTerreno cANCELADO_SIS_DetallesDeTerreno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cANCELADO_SIS_DetallesDeTerreno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cANCELADO_SIS_DetallesDeTerreno);
        }

        // GET: CANCELADO_SIS_DetallesDeTerreno/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_DetallesDeTerreno cANCELADO_SIS_DetallesDeTerreno = db.CANCELADO_SIS_DetallesDeTerreno.Find(id);
            if (cANCELADO_SIS_DetallesDeTerreno == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_DetallesDeTerreno);
        }

        // POST: CANCELADO_SIS_DetallesDeTerreno/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CANCELADO_SIS_DetallesDeTerreno cANCELADO_SIS_DetallesDeTerreno = db.CANCELADO_SIS_DetallesDeTerreno.Find(id);
            db.CANCELADO_SIS_DetallesDeTerreno.Remove(cANCELADO_SIS_DetallesDeTerreno);
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
