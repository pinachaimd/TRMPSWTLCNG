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
    public class CANCELADO_CAJAS_TrasladoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CANCELADO_CAJAS_Traslado
        public ActionResult Index()
        {
            return View(db.CANCELADO_CAJAS_Traslado.ToList());
        }

        // GET: CANCELADO_CAJAS_Traslado/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_CAJAS_Traslado cANCELADO_CAJAS_Traslado = db.CANCELADO_CAJAS_Traslado.Find(id);
            if (cANCELADO_CAJAS_Traslado == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_CAJAS_Traslado);
        }

        // GET: CANCELADO_CAJAS_Traslado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CANCELADO_CAJAS_Traslado/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdFolioCajas,IdTipoOperacion,NombreSolicitante,ApellidoPaternoSolicitante,ApellidoMaternoSolicitante,IdUsuario,año,Clave,NumeroDeCuenta,ClaveCatastral,NroTramite")] CANCELADO_CAJAS_Traslado cANCELADO_CAJAS_Traslado)
        {
            if (ModelState.IsValid)
            {
                db.CANCELADO_CAJAS_Traslado.Add(cANCELADO_CAJAS_Traslado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cANCELADO_CAJAS_Traslado);
        }

        // GET: CANCELADO_CAJAS_Traslado/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_CAJAS_Traslado cANCELADO_CAJAS_Traslado = db.CANCELADO_CAJAS_Traslado.Find(id);
            if (cANCELADO_CAJAS_Traslado == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_CAJAS_Traslado);
        }

        // POST: CANCELADO_CAJAS_Traslado/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdFolioCajas,IdTipoOperacion,NombreSolicitante,ApellidoPaternoSolicitante,ApellidoMaternoSolicitante,IdUsuario,año,Clave,NumeroDeCuenta,ClaveCatastral,NroTramite")] CANCELADO_CAJAS_Traslado cANCELADO_CAJAS_Traslado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cANCELADO_CAJAS_Traslado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cANCELADO_CAJAS_Traslado);
        }

        // GET: CANCELADO_CAJAS_Traslado/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_CAJAS_Traslado cANCELADO_CAJAS_Traslado = db.CANCELADO_CAJAS_Traslado.Find(id);
            if (cANCELADO_CAJAS_Traslado == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_CAJAS_Traslado);
        }

        // POST: CANCELADO_CAJAS_Traslado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CANCELADO_CAJAS_Traslado cANCELADO_CAJAS_Traslado = db.CANCELADO_CAJAS_Traslado.Find(id);
            db.CANCELADO_CAJAS_Traslado.Remove(cANCELADO_CAJAS_Traslado);
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
