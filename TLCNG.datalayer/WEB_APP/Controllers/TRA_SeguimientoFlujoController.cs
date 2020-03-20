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
    public class TRA_SeguimientoFlujoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: TRA_SeguimientoFlujo
        public ActionResult Index()
        {
            var tRA_SeguimientoFlujo = db.TRA_SeguimientoFlujo.Include(t => t.CAT_TRASLADOS_EstatusFlujo).Include(t => t.CAT_TRASLADOS_TareasFlujo);
            return View(tRA_SeguimientoFlujo.ToList());
        }

        // GET: TRA_SeguimientoFlujo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_SeguimientoFlujo tRA_SeguimientoFlujo = db.TRA_SeguimientoFlujo.Find(id);
            if (tRA_SeguimientoFlujo == null)
            {
                return HttpNotFound();
            }
            return View(tRA_SeguimientoFlujo);
        }

        // GET: TRA_SeguimientoFlujo/Create
        public ActionResult Create()
        {
            ViewBag.Estatus = new SelectList(db.CAT_TRASLADOS_EstatusFlujo, "id", "descripcion");
            ViewBag.tarea = new SelectList(db.CAT_TRASLADOS_TareasFlujo, "id", "descripcion");
            return View();
        }

        // POST: TRA_SeguimientoFlujo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nroTramite,tarea,tipoFlujo,Estatus,observaciones,duracion,orden,TipoProceso,idUsuario")] TRA_SeguimientoFlujo tRA_SeguimientoFlujo)
        {
            if (ModelState.IsValid)
            {
                db.TRA_SeguimientoFlujo.Add(tRA_SeguimientoFlujo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Estatus = new SelectList(db.CAT_TRASLADOS_EstatusFlujo, "id", "descripcion", tRA_SeguimientoFlujo.Estatus);
            ViewBag.tarea = new SelectList(db.CAT_TRASLADOS_TareasFlujo, "id", "descripcion", tRA_SeguimientoFlujo.tarea);
            return View(tRA_SeguimientoFlujo);
        }

        // GET: TRA_SeguimientoFlujo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_SeguimientoFlujo tRA_SeguimientoFlujo = db.TRA_SeguimientoFlujo.Find(id);
            if (tRA_SeguimientoFlujo == null)
            {
                return HttpNotFound();
            }
            ViewBag.Estatus = new SelectList(db.CAT_TRASLADOS_EstatusFlujo, "id", "descripcion", tRA_SeguimientoFlujo.Estatus);
            ViewBag.tarea = new SelectList(db.CAT_TRASLADOS_TareasFlujo, "id", "descripcion", tRA_SeguimientoFlujo.tarea);
            return View(tRA_SeguimientoFlujo);
        }

        // POST: TRA_SeguimientoFlujo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nroTramite,tarea,tipoFlujo,Estatus,observaciones,duracion,orden,TipoProceso,idUsuario")] TRA_SeguimientoFlujo tRA_SeguimientoFlujo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tRA_SeguimientoFlujo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Estatus = new SelectList(db.CAT_TRASLADOS_EstatusFlujo, "id", "descripcion", tRA_SeguimientoFlujo.Estatus);
            ViewBag.tarea = new SelectList(db.CAT_TRASLADOS_TareasFlujo, "id", "descripcion", tRA_SeguimientoFlujo.tarea);
            return View(tRA_SeguimientoFlujo);
        }

        // GET: TRA_SeguimientoFlujo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_SeguimientoFlujo tRA_SeguimientoFlujo = db.TRA_SeguimientoFlujo.Find(id);
            if (tRA_SeguimientoFlujo == null)
            {
                return HttpNotFound();
            }
            return View(tRA_SeguimientoFlujo);
        }

        // POST: TRA_SeguimientoFlujo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TRA_SeguimientoFlujo tRA_SeguimientoFlujo = db.TRA_SeguimientoFlujo.Find(id);
            db.TRA_SeguimientoFlujo.Remove(tRA_SeguimientoFlujo);
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
