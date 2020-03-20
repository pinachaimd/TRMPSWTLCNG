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
    public class CAJAS_ConstanciasController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAJAS_Constancias
        public ActionResult Index()
        {
            var cAJAS_Constancias = db.CAJAS_Constancias.Include(c => c.CAT_CAJAS_TipoConstancia);
            return View(cAJAS_Constancias.ToList());
        }

        // GET: CAJAS_Constancias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_Constancias cAJAS_Constancias = db.CAJAS_Constancias.Find(id);
            if (cAJAS_Constancias == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_Constancias);
        }

        // GET: CAJAS_Constancias/Create
        public ActionResult Create()
        {
            ViewBag.IdTipoConstancia = new SelectList(db.CAT_CAJAS_TipoConstancia, "Id", "NombreConstancia");
            return View();
        }

        // POST: CAJAS_Constancias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdFolio,IdTipoConstancia,NombreSolicitante,ApellidoPaternoSolicitante,ApellidoMaternoSolicitante,IdUsuario,año,Clave,NumeroDeCuenta,ClaveCatastral")] CAJAS_Constancias cAJAS_Constancias)
        {
            if (ModelState.IsValid)
            {
                db.CAJAS_Constancias.Add(cAJAS_Constancias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdTipoConstancia = new SelectList(db.CAT_CAJAS_TipoConstancia, "Id", "NombreConstancia", cAJAS_Constancias.IdTipoConstancia);
            return View(cAJAS_Constancias);
        }

        // GET: CAJAS_Constancias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_Constancias cAJAS_Constancias = db.CAJAS_Constancias.Find(id);
            if (cAJAS_Constancias == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdTipoConstancia = new SelectList(db.CAT_CAJAS_TipoConstancia, "Id", "NombreConstancia", cAJAS_Constancias.IdTipoConstancia);
            return View(cAJAS_Constancias);
        }

        // POST: CAJAS_Constancias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdFolio,IdTipoConstancia,NombreSolicitante,ApellidoPaternoSolicitante,ApellidoMaternoSolicitante,IdUsuario,año,Clave,NumeroDeCuenta,ClaveCatastral")] CAJAS_Constancias cAJAS_Constancias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAJAS_Constancias).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdTipoConstancia = new SelectList(db.CAT_CAJAS_TipoConstancia, "Id", "NombreConstancia", cAJAS_Constancias.IdTipoConstancia);
            return View(cAJAS_Constancias);
        }

        // GET: CAJAS_Constancias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_Constancias cAJAS_Constancias = db.CAJAS_Constancias.Find(id);
            if (cAJAS_Constancias == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_Constancias);
        }

        // POST: CAJAS_Constancias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAJAS_Constancias cAJAS_Constancias = db.CAJAS_Constancias.Find(id);
            db.CAJAS_Constancias.Remove(cAJAS_Constancias);
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
