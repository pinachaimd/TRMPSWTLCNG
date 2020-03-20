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
    public class SIS_AvaluosEjecucionController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_AvaluosEjecucion
        public ActionResult Index()
        {
            return View(db.SIS_AvaluosEjecucion.ToList());
        }

        // GET: SIS_AvaluosEjecucion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_AvaluosEjecucion sIS_AvaluosEjecucion = db.SIS_AvaluosEjecucion.Find(id);
            if (sIS_AvaluosEjecucion == null)
            {
                return HttpNotFound();
            }
            return View(sIS_AvaluosEjecucion);
        }

        // GET: SIS_AvaluosEjecucion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_AvaluosEjecucion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,BaseGravable,AreaTerreno,Municipio,Edificio,TipoOperacion,DescripcionOperacion,ClaveOrigen,NumeroDeCuentaOrigen,ClaveCatastralOrigen,Estatus")] SIS_AvaluosEjecucion sIS_AvaluosEjecucion)
        {
            if (ModelState.IsValid)
            {
                db.SIS_AvaluosEjecucion.Add(sIS_AvaluosEjecucion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_AvaluosEjecucion);
        }

        // GET: SIS_AvaluosEjecucion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_AvaluosEjecucion sIS_AvaluosEjecucion = db.SIS_AvaluosEjecucion.Find(id);
            if (sIS_AvaluosEjecucion == null)
            {
                return HttpNotFound();
            }
            return View(sIS_AvaluosEjecucion);
        }

        // POST: SIS_AvaluosEjecucion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,BaseGravable,AreaTerreno,Municipio,Edificio,TipoOperacion,DescripcionOperacion,ClaveOrigen,NumeroDeCuentaOrigen,ClaveCatastralOrigen,Estatus")] SIS_AvaluosEjecucion sIS_AvaluosEjecucion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_AvaluosEjecucion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_AvaluosEjecucion);
        }

        // GET: SIS_AvaluosEjecucion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_AvaluosEjecucion sIS_AvaluosEjecucion = db.SIS_AvaluosEjecucion.Find(id);
            if (sIS_AvaluosEjecucion == null)
            {
                return HttpNotFound();
            }
            return View(sIS_AvaluosEjecucion);
        }

        // POST: SIS_AvaluosEjecucion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_AvaluosEjecucion sIS_AvaluosEjecucion = db.SIS_AvaluosEjecucion.Find(id);
            db.SIS_AvaluosEjecucion.Remove(sIS_AvaluosEjecucion);
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
