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
    public class CAJAS_PagosAvaluosPendientesController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAJAS_PagosAvaluosPendientes
        public ActionResult Index()
        {
            return View(db.CAJAS_PagosAvaluosPendientes.ToList());
        }

        // GET: CAJAS_PagosAvaluosPendientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_PagosAvaluosPendientes cAJAS_PagosAvaluosPendientes = db.CAJAS_PagosAvaluosPendientes.Find(id);
            if (cAJAS_PagosAvaluosPendientes == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_PagosAvaluosPendientes);
        }

        // GET: CAJAS_PagosAvaluosPendientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAJAS_PagosAvaluosPendientes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,claveCatastral,clave,cuenta,costoAvaluo,pagado,nombrePropietario,apellidoPaternoPropietario,apellidoMaternoPropietario,nombreComercial,direccion,Comunidad,mtsTerreno,mtsConstUrbana,mtsConstComercial,mtsConstIndustrial,valorCatastral,IdFolio,numeroTramite,condonacionAvaluo")] CAJAS_PagosAvaluosPendientes cAJAS_PagosAvaluosPendientes)
        {
            if (ModelState.IsValid)
            {
                db.CAJAS_PagosAvaluosPendientes.Add(cAJAS_PagosAvaluosPendientes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAJAS_PagosAvaluosPendientes);
        }

        // GET: CAJAS_PagosAvaluosPendientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_PagosAvaluosPendientes cAJAS_PagosAvaluosPendientes = db.CAJAS_PagosAvaluosPendientes.Find(id);
            if (cAJAS_PagosAvaluosPendientes == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_PagosAvaluosPendientes);
        }

        // POST: CAJAS_PagosAvaluosPendientes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,claveCatastral,clave,cuenta,costoAvaluo,pagado,nombrePropietario,apellidoPaternoPropietario,apellidoMaternoPropietario,nombreComercial,direccion,Comunidad,mtsTerreno,mtsConstUrbana,mtsConstComercial,mtsConstIndustrial,valorCatastral,IdFolio,numeroTramite,condonacionAvaluo")] CAJAS_PagosAvaluosPendientes cAJAS_PagosAvaluosPendientes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAJAS_PagosAvaluosPendientes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAJAS_PagosAvaluosPendientes);
        }

        // GET: CAJAS_PagosAvaluosPendientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_PagosAvaluosPendientes cAJAS_PagosAvaluosPendientes = db.CAJAS_PagosAvaluosPendientes.Find(id);
            if (cAJAS_PagosAvaluosPendientes == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_PagosAvaluosPendientes);
        }

        // POST: CAJAS_PagosAvaluosPendientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAJAS_PagosAvaluosPendientes cAJAS_PagosAvaluosPendientes = db.CAJAS_PagosAvaluosPendientes.Find(id);
            db.CAJAS_PagosAvaluosPendientes.Remove(cAJAS_PagosAvaluosPendientes);
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
