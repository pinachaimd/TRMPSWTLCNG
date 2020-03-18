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
    public class CAJAS_HistorialBancosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAJAS_HistorialBancos
        public ActionResult Index()
        {
            return View(db.CAJAS_HistorialBancos.ToList());
        }

        // GET: CAJAS_HistorialBancos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_HistorialBancos cAJAS_HistorialBancos = db.CAJAS_HistorialBancos.Find(id);
            if (cAJAS_HistorialBancos == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_HistorialBancos);
        }

        // GET: CAJAS_HistorialBancos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAJAS_HistorialBancos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Folio,IdFormaDePago,IdUsuario,FolioUsado,ReferenciaBanco,FechaPago,Clave,NumeroDeCuenta")] CAJAS_HistorialBancos cAJAS_HistorialBancos)
        {
            if (ModelState.IsValid)
            {
                db.CAJAS_HistorialBancos.Add(cAJAS_HistorialBancos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAJAS_HistorialBancos);
        }

        // GET: CAJAS_HistorialBancos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_HistorialBancos cAJAS_HistorialBancos = db.CAJAS_HistorialBancos.Find(id);
            if (cAJAS_HistorialBancos == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_HistorialBancos);
        }

        // POST: CAJAS_HistorialBancos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Folio,IdFormaDePago,IdUsuario,FolioUsado,ReferenciaBanco,FechaPago,Clave,NumeroDeCuenta")] CAJAS_HistorialBancos cAJAS_HistorialBancos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAJAS_HistorialBancos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAJAS_HistorialBancos);
        }

        // GET: CAJAS_HistorialBancos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAJAS_HistorialBancos cAJAS_HistorialBancos = db.CAJAS_HistorialBancos.Find(id);
            if (cAJAS_HistorialBancos == null)
            {
                return HttpNotFound();
            }
            return View(cAJAS_HistorialBancos);
        }

        // POST: CAJAS_HistorialBancos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAJAS_HistorialBancos cAJAS_HistorialBancos = db.CAJAS_HistorialBancos.Find(id);
            db.CAJAS_HistorialBancos.Remove(cAJAS_HistorialBancos);
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
