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
    public class CAJAS_AvaluosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAJAS_Avaluos
        public ActionResult Index()
        {
            return View(db.CAJAS_Avaluos.ToList());
        }

        // GET: CAJAS_Avaluos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_Avaluos cAJAS_Avaluos = db.CAJAS_Avaluos.Find(id);
            if (cAJAS_Avaluos == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_Avaluos);
        }

        // GET: CAJAS_Avaluos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAJAS_Avaluos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdFolio,IdTipoOperacion,NombreSolicitante,ApellidoPaternoSolicitante,ApellidoMaternoSolicitante,IdUsuario,año,ClaveCatastral")] CAJAS_Avaluos cAJAS_Avaluos)
        {
            if (ModelState.IsValid)
            {
                db.CAJAS_Avaluos.Add(cAJAS_Avaluos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAJAS_Avaluos);
        }

        // GET: CAJAS_Avaluos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_Avaluos cAJAS_Avaluos = db.CAJAS_Avaluos.Find(id);
            if (cAJAS_Avaluos == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_Avaluos);
        }

        // POST: CAJAS_Avaluos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdFolio,IdTipoOperacion,NombreSolicitante,ApellidoPaternoSolicitante,ApellidoMaternoSolicitante,IdUsuario,año,ClaveCatastral")] CAJAS_Avaluos cAJAS_Avaluos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAJAS_Avaluos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAJAS_Avaluos);
        }

        // GET: CAJAS_Avaluos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_Avaluos cAJAS_Avaluos = db.CAJAS_Avaluos.Find(id);
            if (cAJAS_Avaluos == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_Avaluos);
        }

        // POST: CAJAS_Avaluos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAJAS_Avaluos cAJAS_Avaluos = db.CAJAS_Avaluos.Find(id);
            db.CAJAS_Avaluos.Remove(cAJAS_Avaluos);
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
