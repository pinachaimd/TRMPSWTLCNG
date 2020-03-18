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
    public class TRA_FlujoxProcesoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: TRA_FlujoxProceso
        public ActionResult Index()
        {
            var tRA_FlujoxProceso = db.TRA_FlujoxProceso.Include(t => t.CAT_TRASLADOS_TipoProceso);
            return View(tRA_FlujoxProceso.ToList());
        }

        // GET: TRA_FlujoxProceso/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_FlujoxProceso tRA_FlujoxProceso = db.TRA_FlujoxProceso.Find(id);
            if (tRA_FlujoxProceso == null)
            {
                return HttpNotFound();
            }
            return View(tRA_FlujoxProceso);
        }

        // GET: TRA_FlujoxProceso/Create
        public ActionResult Create()
        {
            ViewBag.TipoProceso = new SelectList(db.CAT_TRASLADOS_TipoProceso, "id", "nombre");
            return View();
        }

        // POST: TRA_FlujoxProceso/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,tarea,TipoProceso,ordenDeRealizacion,tiempoAproximado,requiereAnteriorFinalizado")] TRA_FlujoxProceso tRA_FlujoxProceso)
        {
            if (ModelState.IsValid)
            {
                db.TRA_FlujoxProceso.Add(tRA_FlujoxProceso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TipoProceso = new SelectList(db.CAT_TRASLADOS_TipoProceso, "id", "nombre", tRA_FlujoxProceso.TipoProceso);
            return View(tRA_FlujoxProceso);
        }

        // GET: TRA_FlujoxProceso/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_FlujoxProceso tRA_FlujoxProceso = db.TRA_FlujoxProceso.Find(id);
            if (tRA_FlujoxProceso == null)
            {
                return HttpNotFound();
            }
            ViewBag.TipoProceso = new SelectList(db.CAT_TRASLADOS_TipoProceso, "id", "nombre", tRA_FlujoxProceso.TipoProceso);
            return View(tRA_FlujoxProceso);
        }

        // POST: TRA_FlujoxProceso/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,tarea,TipoProceso,ordenDeRealizacion,tiempoAproximado,requiereAnteriorFinalizado")] TRA_FlujoxProceso tRA_FlujoxProceso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tRA_FlujoxProceso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TipoProceso = new SelectList(db.CAT_TRASLADOS_TipoProceso, "id", "nombre", tRA_FlujoxProceso.TipoProceso);
            return View(tRA_FlujoxProceso);
        }

        // GET: TRA_FlujoxProceso/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_FlujoxProceso tRA_FlujoxProceso = db.TRA_FlujoxProceso.Find(id);
            if (tRA_FlujoxProceso == null)
            {
                return HttpNotFound();
            }
            return View(tRA_FlujoxProceso);
        }

        // POST: TRA_FlujoxProceso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TRA_FlujoxProceso tRA_FlujoxProceso = db.TRA_FlujoxProceso.Find(id);
            db.TRA_FlujoxProceso.Remove(tRA_FlujoxProceso);
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
