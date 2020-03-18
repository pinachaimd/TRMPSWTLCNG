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
    public class CAJAS_HistorialTrasladosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAJAS_HistorialTraslados
        public ActionResult Index()
        {
            return View(db.CAJAS_HistorialTraslados.ToList());
        }

        // GET: CAJAS_HistorialTraslados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_HistorialTraslados cAJAS_HistorialTraslados = db.CAJAS_HistorialTraslados.Find(id);
            if (cAJAS_HistorialTraslados == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_HistorialTraslados);
        }

        // GET: CAJAS_HistorialTraslados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAJAS_HistorialTraslados/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FolioTraslado,TipoOperacion,ValorSobre,Cobro,TipoDePago,Año")] CAJAS_HistorialTraslados cAJAS_HistorialTraslados)
        {
            if (ModelState.IsValid)
            {
                db.CAJAS_HistorialTraslados.Add(cAJAS_HistorialTraslados);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAJAS_HistorialTraslados);
        }

        // GET: CAJAS_HistorialTraslados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_HistorialTraslados cAJAS_HistorialTraslados = db.CAJAS_HistorialTraslados.Find(id);
            if (cAJAS_HistorialTraslados == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_HistorialTraslados);
        }

        // POST: CAJAS_HistorialTraslados/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FolioTraslado,TipoOperacion,ValorSobre,Cobro,TipoDePago,Año")] CAJAS_HistorialTraslados cAJAS_HistorialTraslados)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAJAS_HistorialTraslados).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAJAS_HistorialTraslados);
        }

        // GET: CAJAS_HistorialTraslados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_HistorialTraslados cAJAS_HistorialTraslados = db.CAJAS_HistorialTraslados.Find(id);
            if (cAJAS_HistorialTraslados == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_HistorialTraslados);
        }

        // POST: CAJAS_HistorialTraslados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAJAS_HistorialTraslados cAJAS_HistorialTraslados = db.CAJAS_HistorialTraslados.Find(id);
            db.CAJAS_HistorialTraslados.Remove(cAJAS_HistorialTraslados);
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
