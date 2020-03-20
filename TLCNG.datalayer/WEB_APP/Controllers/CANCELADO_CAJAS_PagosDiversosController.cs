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
    public class CANCELADO_CAJAS_PagosDiversosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CANCELADO_CAJAS_PagosDiversos
        public ActionResult Index()
        {
            return View(db.CANCELADO_CAJAS_PagosDiversos.ToList());
        }

        // GET: CANCELADO_CAJAS_PagosDiversos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_CAJAS_PagosDiversos cANCELADO_CAJAS_PagosDiversos = db.CANCELADO_CAJAS_PagosDiversos.Find(id);
            if (cANCELADO_CAJAS_PagosDiversos == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_CAJAS_PagosDiversos);
        }

        // GET: CANCELADO_CAJAS_PagosDiversos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CANCELADO_CAJAS_PagosDiversos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdFolio,NombreSolicitante,ApellidoPaternoSolicitante,ApellidoMaternoSolicitante,Direccion,Concepto,TotalPagado,NombreComercial,Descripicion,Rfc,Calle,Colonia,Estado,NombreRFC,CP,IdUsuario")] CANCELADO_CAJAS_PagosDiversos cANCELADO_CAJAS_PagosDiversos)
        {
            if (ModelState.IsValid)
            {
                db.CANCELADO_CAJAS_PagosDiversos.Add(cANCELADO_CAJAS_PagosDiversos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cANCELADO_CAJAS_PagosDiversos);
        }

        // GET: CANCELADO_CAJAS_PagosDiversos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_CAJAS_PagosDiversos cANCELADO_CAJAS_PagosDiversos = db.CANCELADO_CAJAS_PagosDiversos.Find(id);
            if (cANCELADO_CAJAS_PagosDiversos == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_CAJAS_PagosDiversos);
        }

        // POST: CANCELADO_CAJAS_PagosDiversos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdFolio,NombreSolicitante,ApellidoPaternoSolicitante,ApellidoMaternoSolicitante,Direccion,Concepto,TotalPagado,NombreComercial,Descripicion,Rfc,Calle,Colonia,Estado,NombreRFC,CP,IdUsuario")] CANCELADO_CAJAS_PagosDiversos cANCELADO_CAJAS_PagosDiversos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cANCELADO_CAJAS_PagosDiversos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cANCELADO_CAJAS_PagosDiversos);
        }

        // GET: CANCELADO_CAJAS_PagosDiversos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_CAJAS_PagosDiversos cANCELADO_CAJAS_PagosDiversos = db.CANCELADO_CAJAS_PagosDiversos.Find(id);
            if (cANCELADO_CAJAS_PagosDiversos == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_CAJAS_PagosDiversos);
        }

        // POST: CANCELADO_CAJAS_PagosDiversos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CANCELADO_CAJAS_PagosDiversos cANCELADO_CAJAS_PagosDiversos = db.CANCELADO_CAJAS_PagosDiversos.Find(id);
            db.CANCELADO_CAJAS_PagosDiversos.Remove(cANCELADO_CAJAS_PagosDiversos);
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
