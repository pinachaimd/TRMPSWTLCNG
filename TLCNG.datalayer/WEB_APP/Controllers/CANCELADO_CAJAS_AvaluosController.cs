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
    public class CANCELADO_CAJAS_AvaluosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CANCELADO_CAJAS_Avaluos
        public ActionResult Index()
        {
            return View(db.CANCELADO_CAJAS_Avaluos.ToList());
        }

        // GET: CANCELADO_CAJAS_Avaluos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_CAJAS_Avaluos cANCELADO_CAJAS_Avaluos = db.CANCELADO_CAJAS_Avaluos.Find(id);
            if (cANCELADO_CAJAS_Avaluos == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_CAJAS_Avaluos);
        }

        // GET: CANCELADO_CAJAS_Avaluos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CANCELADO_CAJAS_Avaluos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdFolio,IdTipoOperacion,NombreSolicitante,ApellidoPaternoSolicitante,ApellidoMaternoSolicitante,IdUsuario,año,ClaveCatastral")] CANCELADO_CAJAS_Avaluos cANCELADO_CAJAS_Avaluos)
        {
            if (ModelState.IsValid)
            {
                db.CANCELADO_CAJAS_Avaluos.Add(cANCELADO_CAJAS_Avaluos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cANCELADO_CAJAS_Avaluos);
        }

        // GET: CANCELADO_CAJAS_Avaluos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_CAJAS_Avaluos cANCELADO_CAJAS_Avaluos = db.CANCELADO_CAJAS_Avaluos.Find(id);
            if (cANCELADO_CAJAS_Avaluos == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_CAJAS_Avaluos);
        }

        // POST: CANCELADO_CAJAS_Avaluos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdFolio,IdTipoOperacion,NombreSolicitante,ApellidoPaternoSolicitante,ApellidoMaternoSolicitante,IdUsuario,año,ClaveCatastral")] CANCELADO_CAJAS_Avaluos cANCELADO_CAJAS_Avaluos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cANCELADO_CAJAS_Avaluos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cANCELADO_CAJAS_Avaluos);
        }

        // GET: CANCELADO_CAJAS_Avaluos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_CAJAS_Avaluos cANCELADO_CAJAS_Avaluos = db.CANCELADO_CAJAS_Avaluos.Find(id);
            if (cANCELADO_CAJAS_Avaluos == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_CAJAS_Avaluos);
        }

        // POST: CANCELADO_CAJAS_Avaluos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CANCELADO_CAJAS_Avaluos cANCELADO_CAJAS_Avaluos = db.CANCELADO_CAJAS_Avaluos.Find(id);
            db.CANCELADO_CAJAS_Avaluos.Remove(cANCELADO_CAJAS_Avaluos);
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
