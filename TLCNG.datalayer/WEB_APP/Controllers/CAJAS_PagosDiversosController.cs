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
    public class CAJAS_PagosDiversosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAJAS_PagosDiversos
        public ActionResult Index()
        {
            return View(db.CAJAS_PagosDiversos.ToList());
        }

        // GET: CAJAS_PagosDiversos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_PagosDiversos cAJAS_PagosDiversos = db.CAJAS_PagosDiversos.Find(id);
            if (cAJAS_PagosDiversos == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_PagosDiversos);
        }

        // GET: CAJAS_PagosDiversos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAJAS_PagosDiversos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdFolio,NombreSolicitante,ApellidoPaternoSolicitante,ApellidoMaternoSolicitante,Direccion,Concepto,TotalPagado,NombreComercial,Descripicion,Rfc,Calle,Colonia,Estado,NombreRFC,CP,IdUsuario")] CAJAS_PagosDiversos cAJAS_PagosDiversos)
        {
            if (ModelState.IsValid)
            {
                db.CAJAS_PagosDiversos.Add(cAJAS_PagosDiversos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAJAS_PagosDiversos);
        }

        // GET: CAJAS_PagosDiversos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_PagosDiversos cAJAS_PagosDiversos = db.CAJAS_PagosDiversos.Find(id);
            if (cAJAS_PagosDiversos == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_PagosDiversos);
        }

        // POST: CAJAS_PagosDiversos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdFolio,NombreSolicitante,ApellidoPaternoSolicitante,ApellidoMaternoSolicitante,Direccion,Concepto,TotalPagado,NombreComercial,Descripicion,Rfc,Calle,Colonia,Estado,NombreRFC,CP,IdUsuario")] CAJAS_PagosDiversos cAJAS_PagosDiversos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAJAS_PagosDiversos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAJAS_PagosDiversos);
        }

        // GET: CAJAS_PagosDiversos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_PagosDiversos cAJAS_PagosDiversos = db.CAJAS_PagosDiversos.Find(id);
            if (cAJAS_PagosDiversos == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_PagosDiversos);
        }

        // POST: CAJAS_PagosDiversos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAJAS_PagosDiversos cAJAS_PagosDiversos = db.CAJAS_PagosDiversos.Find(id);
            db.CAJAS_PagosDiversos.Remove(cAJAS_PagosDiversos);
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
