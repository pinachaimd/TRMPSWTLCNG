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
    public class TRA_TramiteController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: TRA_Tramite
        public ActionResult Index()
        {
            var tRA_Tramite = db.TRA_Tramite.Include(t => t.CAT_TRASLADOS_Solicitante).Include(t => t.CAT_TRASLADOS_TipoProceso);
            return View(tRA_Tramite.ToList());
        }

        // GET: TRA_Tramite/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_Tramite tRA_Tramite = db.TRA_Tramite.Find(id);
            if (tRA_Tramite == null)
            {
                return HttpNotFound();
            }
            return View(tRA_Tramite);
        }

        // GET: TRA_Tramite/Create
        public ActionResult Create()
        {
            ViewBag.Solicitante = new SelectList(db.CAT_TRASLADOS_Solicitante, "id", "nombre");
            ViewBag.IdTipoProceso = new SelectList(db.CAT_TRASLADOS_TipoProceso, "id", "nombre");
            return View();
        }

        // POST: TRA_Tramite/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,clavecatastral,fechaInicial,fechaFinal,Estatus,Observaciones,IdTipoProceso,IdUsuario,Municipio,region,manzana,predio,edificio,condominio,numeroCuenta,nroTramite,Solicitante,nombreSolicitante,obsAclaracion,procede,clave,año,consecutivo,nombreApellidoPaterno,nombreApellidoMaterno,NumeroEscritura")] TRA_Tramite tRA_Tramite)
        {
            if (ModelState.IsValid)
            {
                db.TRA_Tramite.Add(tRA_Tramite);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Solicitante = new SelectList(db.CAT_TRASLADOS_Solicitante, "id", "nombre", tRA_Tramite.Solicitante);
            ViewBag.IdTipoProceso = new SelectList(db.CAT_TRASLADOS_TipoProceso, "id", "nombre", tRA_Tramite.IdTipoProceso);
            return View(tRA_Tramite);
        }

        // GET: TRA_Tramite/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_Tramite tRA_Tramite = db.TRA_Tramite.Find(id);
            if (tRA_Tramite == null)
            {
                return HttpNotFound();
            }
            ViewBag.Solicitante = new SelectList(db.CAT_TRASLADOS_Solicitante, "id", "nombre", tRA_Tramite.Solicitante);
            ViewBag.IdTipoProceso = new SelectList(db.CAT_TRASLADOS_TipoProceso, "id", "nombre", tRA_Tramite.IdTipoProceso);
            return View(tRA_Tramite);
        }

        // POST: TRA_Tramite/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,clavecatastral,fechaInicial,fechaFinal,Estatus,Observaciones,IdTipoProceso,IdUsuario,Municipio,region,manzana,predio,edificio,condominio,numeroCuenta,nroTramite,Solicitante,nombreSolicitante,obsAclaracion,procede,clave,año,consecutivo,nombreApellidoPaterno,nombreApellidoMaterno,NumeroEscritura")] TRA_Tramite tRA_Tramite)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tRA_Tramite).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Solicitante = new SelectList(db.CAT_TRASLADOS_Solicitante, "id", "nombre", tRA_Tramite.Solicitante);
            ViewBag.IdTipoProceso = new SelectList(db.CAT_TRASLADOS_TipoProceso, "id", "nombre", tRA_Tramite.IdTipoProceso);
            return View(tRA_Tramite);
        }

        // GET: TRA_Tramite/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_Tramite tRA_Tramite = db.TRA_Tramite.Find(id);
            if (tRA_Tramite == null)
            {
                return HttpNotFound();
            }
            return View(tRA_Tramite);
        }

        // POST: TRA_Tramite/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TRA_Tramite tRA_Tramite = db.TRA_Tramite.Find(id);
            db.TRA_Tramite.Remove(tRA_Tramite);
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
