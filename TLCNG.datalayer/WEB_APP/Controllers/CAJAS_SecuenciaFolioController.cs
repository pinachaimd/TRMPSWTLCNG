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
    public class CAJAS_SecuenciaFolioController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAJAS_SecuenciaFolio
        public ActionResult Index()
        {
            return View(db.CAJAS_SecuenciaFolio.ToList());
        }

        // GET: CAJAS_SecuenciaFolio/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_SecuenciaFolio cAJAS_SecuenciaFolio = db.CAJAS_SecuenciaFolio.Find(id);
            if (cAJAS_SecuenciaFolio == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_SecuenciaFolio);
        }

        // GET: CAJAS_SecuenciaFolio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAJAS_SecuenciaFolio/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Folio,Descripcion")] CAJAS_SecuenciaFolio cAJAS_SecuenciaFolio)
        {
            if (ModelState.IsValid)
            {
                db.CAJAS_SecuenciaFolio.Add(cAJAS_SecuenciaFolio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAJAS_SecuenciaFolio);
        }

        // GET: CAJAS_SecuenciaFolio/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_SecuenciaFolio cAJAS_SecuenciaFolio = db.CAJAS_SecuenciaFolio.Find(id);
            if (cAJAS_SecuenciaFolio == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_SecuenciaFolio);
        }

        // POST: CAJAS_SecuenciaFolio/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Folio,Descripcion")] CAJAS_SecuenciaFolio cAJAS_SecuenciaFolio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAJAS_SecuenciaFolio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAJAS_SecuenciaFolio);
        }

        // GET: CAJAS_SecuenciaFolio/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_SecuenciaFolio cAJAS_SecuenciaFolio = db.CAJAS_SecuenciaFolio.Find(id);
            if (cAJAS_SecuenciaFolio == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_SecuenciaFolio);
        }

        // POST: CAJAS_SecuenciaFolio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAJAS_SecuenciaFolio cAJAS_SecuenciaFolio = db.CAJAS_SecuenciaFolio.Find(id);
            db.CAJAS_SecuenciaFolio.Remove(cAJAS_SecuenciaFolio);
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
