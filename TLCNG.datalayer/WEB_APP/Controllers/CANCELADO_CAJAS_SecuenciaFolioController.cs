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
    public class CANCELADO_CAJAS_SecuenciaFolioController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CANCELADO_CAJAS_SecuenciaFolio
        public ActionResult Index()
        {
            return View(db.CANCELADO_CAJAS_SecuenciaFolio.ToList());
        }

        // GET: CANCELADO_CAJAS_SecuenciaFolio/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_CAJAS_SecuenciaFolio cANCELADO_CAJAS_SecuenciaFolio = db.CANCELADO_CAJAS_SecuenciaFolio.Find(id);
            if (cANCELADO_CAJAS_SecuenciaFolio == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_CAJAS_SecuenciaFolio);
        }

        // GET: CANCELADO_CAJAS_SecuenciaFolio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CANCELADO_CAJAS_SecuenciaFolio/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Folio,Descripcion")] CANCELADO_CAJAS_SecuenciaFolio cANCELADO_CAJAS_SecuenciaFolio)
        {
            if (ModelState.IsValid)
            {
                db.CANCELADO_CAJAS_SecuenciaFolio.Add(cANCELADO_CAJAS_SecuenciaFolio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cANCELADO_CAJAS_SecuenciaFolio);
        }

        // GET: CANCELADO_CAJAS_SecuenciaFolio/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_CAJAS_SecuenciaFolio cANCELADO_CAJAS_SecuenciaFolio = db.CANCELADO_CAJAS_SecuenciaFolio.Find(id);
            if (cANCELADO_CAJAS_SecuenciaFolio == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_CAJAS_SecuenciaFolio);
        }

        // POST: CANCELADO_CAJAS_SecuenciaFolio/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Folio,Descripcion")] CANCELADO_CAJAS_SecuenciaFolio cANCELADO_CAJAS_SecuenciaFolio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cANCELADO_CAJAS_SecuenciaFolio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cANCELADO_CAJAS_SecuenciaFolio);
        }

        // GET: CANCELADO_CAJAS_SecuenciaFolio/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_CAJAS_SecuenciaFolio cANCELADO_CAJAS_SecuenciaFolio = db.CANCELADO_CAJAS_SecuenciaFolio.Find(id);
            if (cANCELADO_CAJAS_SecuenciaFolio == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_CAJAS_SecuenciaFolio);
        }

        // POST: CANCELADO_CAJAS_SecuenciaFolio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CANCELADO_CAJAS_SecuenciaFolio cANCELADO_CAJAS_SecuenciaFolio = db.CANCELADO_CAJAS_SecuenciaFolio.Find(id);
            db.CANCELADO_CAJAS_SecuenciaFolio.Remove(cANCELADO_CAJAS_SecuenciaFolio);
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
