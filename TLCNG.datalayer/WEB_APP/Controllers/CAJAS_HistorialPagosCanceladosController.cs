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
    public class CAJAS_HistorialPagosCanceladosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAJAS_HistorialPagosCancelados
        public ActionResult Index()
        {
            return View(db.CAJAS_HistorialPagosCancelados.ToList());
        }

        // GET: CAJAS_HistorialPagosCancelados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_HistorialPagosCancelados cAJAS_HistorialPagosCancelados = db.CAJAS_HistorialPagosCancelados.Find(id);
            if (cAJAS_HistorialPagosCancelados == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_HistorialPagosCancelados);
        }

        // GET: CAJAS_HistorialPagosCancelados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAJAS_HistorialPagosCancelados/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Folio,Clave,NumeroDeCuenta,TipoDePago,IdUsuario,FechaPago,FechaCancelacion,CantidadDeBimestres,CantidadAñoActual,CantidadAño_5,CantidadAño_4,CantidadAño_3,CantidadAño_2,CantidadAño_1,Año")] CAJAS_HistorialPagosCancelados cAJAS_HistorialPagosCancelados)
        {
            if (ModelState.IsValid)
            {
                db.CAJAS_HistorialPagosCancelados.Add(cAJAS_HistorialPagosCancelados);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAJAS_HistorialPagosCancelados);
        }

        // GET: CAJAS_HistorialPagosCancelados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_HistorialPagosCancelados cAJAS_HistorialPagosCancelados = db.CAJAS_HistorialPagosCancelados.Find(id);
            if (cAJAS_HistorialPagosCancelados == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_HistorialPagosCancelados);
        }

        // POST: CAJAS_HistorialPagosCancelados/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Folio,Clave,NumeroDeCuenta,TipoDePago,IdUsuario,FechaPago,FechaCancelacion,CantidadDeBimestres,CantidadAñoActual,CantidadAño_5,CantidadAño_4,CantidadAño_3,CantidadAño_2,CantidadAño_1,Año")] CAJAS_HistorialPagosCancelados cAJAS_HistorialPagosCancelados)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAJAS_HistorialPagosCancelados).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAJAS_HistorialPagosCancelados);
        }

        // GET: CAJAS_HistorialPagosCancelados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_HistorialPagosCancelados cAJAS_HistorialPagosCancelados = db.CAJAS_HistorialPagosCancelados.Find(id);
            if (cAJAS_HistorialPagosCancelados == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_HistorialPagosCancelados);
        }

        // POST: CAJAS_HistorialPagosCancelados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAJAS_HistorialPagosCancelados cAJAS_HistorialPagosCancelados = db.CAJAS_HistorialPagosCancelados.Find(id);
            db.CAJAS_HistorialPagosCancelados.Remove(cAJAS_HistorialPagosCancelados);
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
