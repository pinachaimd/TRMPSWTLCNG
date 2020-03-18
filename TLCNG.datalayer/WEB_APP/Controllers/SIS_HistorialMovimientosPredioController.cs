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
    public class SIS_HistorialMovimientosPredioController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_HistorialMovimientosPredio
        public ActionResult Index()
        {
            var sIS_HistorialMovimientosPredio = db.SIS_HistorialMovimientosPredio.Include(s => s.CAT_TipoCambio).Include(s => s.CAT_TipoOperacion);
            return View(sIS_HistorialMovimientosPredio.ToList());
        }

        // GET: SIS_HistorialMovimientosPredio/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialMovimientosPredio sIS_HistorialMovimientosPredio = db.SIS_HistorialMovimientosPredio.Find(id);
            if (sIS_HistorialMovimientosPredio == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialMovimientosPredio);
        }

        // GET: SIS_HistorialMovimientosPredio/Create
        public ActionResult Create()
        {
            ViewBag.IdTipoCampo = new SelectList(db.CAT_TipoCambio, "Id", "NombreTipoCambio");
            ViewBag.IdTipoOperacion = new SelectList(db.CAT_TipoOperacion, "Id", "NombreOperación");
            return View();
        }

        // POST: SIS_HistorialMovimientosPredio/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Clave,NumeroDeCuenta,IdUsuario,FechaOperacion,IdTipoOperacion,IdTipoCampo")] SIS_HistorialMovimientosPredio sIS_HistorialMovimientosPredio)
        {
            if (ModelState.IsValid)
            {
                db.SIS_HistorialMovimientosPredio.Add(sIS_HistorialMovimientosPredio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdTipoCampo = new SelectList(db.CAT_TipoCambio, "Id", "NombreTipoCambio", sIS_HistorialMovimientosPredio.IdTipoCampo);
            ViewBag.IdTipoOperacion = new SelectList(db.CAT_TipoOperacion, "Id", "NombreOperación", sIS_HistorialMovimientosPredio.IdTipoOperacion);
            return View(sIS_HistorialMovimientosPredio);
        }

        // GET: SIS_HistorialMovimientosPredio/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialMovimientosPredio sIS_HistorialMovimientosPredio = db.SIS_HistorialMovimientosPredio.Find(id);
            if (sIS_HistorialMovimientosPredio == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdTipoCampo = new SelectList(db.CAT_TipoCambio, "Id", "NombreTipoCambio", sIS_HistorialMovimientosPredio.IdTipoCampo);
            ViewBag.IdTipoOperacion = new SelectList(db.CAT_TipoOperacion, "Id", "NombreOperación", sIS_HistorialMovimientosPredio.IdTipoOperacion);
            return View(sIS_HistorialMovimientosPredio);
        }

        // POST: SIS_HistorialMovimientosPredio/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Clave,NumeroDeCuenta,IdUsuario,FechaOperacion,IdTipoOperacion,IdTipoCampo")] SIS_HistorialMovimientosPredio sIS_HistorialMovimientosPredio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_HistorialMovimientosPredio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdTipoCampo = new SelectList(db.CAT_TipoCambio, "Id", "NombreTipoCambio", sIS_HistorialMovimientosPredio.IdTipoCampo);
            ViewBag.IdTipoOperacion = new SelectList(db.CAT_TipoOperacion, "Id", "NombreOperación", sIS_HistorialMovimientosPredio.IdTipoOperacion);
            return View(sIS_HistorialMovimientosPredio);
        }

        // GET: SIS_HistorialMovimientosPredio/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialMovimientosPredio sIS_HistorialMovimientosPredio = db.SIS_HistorialMovimientosPredio.Find(id);
            if (sIS_HistorialMovimientosPredio == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialMovimientosPredio);
        }

        // POST: SIS_HistorialMovimientosPredio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_HistorialMovimientosPredio sIS_HistorialMovimientosPredio = db.SIS_HistorialMovimientosPredio.Find(id);
            db.SIS_HistorialMovimientosPredio.Remove(sIS_HistorialMovimientosPredio);
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
