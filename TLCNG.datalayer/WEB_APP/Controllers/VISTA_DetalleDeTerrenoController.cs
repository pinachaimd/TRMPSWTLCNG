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
    public class VISTA_DetalleDeTerrenoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: VISTA_DetalleDeTerreno
        public ActionResult Index()
        {
            return View(db.VISTA_DetalleDeTerreno.ToList());
        }

        // GET: VISTA_DetalleDeTerreno/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VISTA_DetalleDeTerreno vISTA_DetalleDeTerreno = db.VISTA_DetalleDeTerreno.Find(id);
            if (vISTA_DetalleDeTerreno == null)
            {
                return HttpNotFound();
            }
            return View(vISTA_DetalleDeTerreno);
        }

        // GET: VISTA_DetalleDeTerreno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VISTA_DetalleDeTerreno/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Clave,NumeroDeCuenta,AreaTotal")] VISTA_DetalleDeTerreno vISTA_DetalleDeTerreno)
        {
            if (ModelState.IsValid)
            {
                db.VISTA_DetalleDeTerreno.Add(vISTA_DetalleDeTerreno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vISTA_DetalleDeTerreno);
        }

        // GET: VISTA_DetalleDeTerreno/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VISTA_DetalleDeTerreno vISTA_DetalleDeTerreno = db.VISTA_DetalleDeTerreno.Find(id);
            if (vISTA_DetalleDeTerreno == null)
            {
                return HttpNotFound();
            }
            return View(vISTA_DetalleDeTerreno);
        }

        // POST: VISTA_DetalleDeTerreno/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Clave,NumeroDeCuenta,AreaTotal")] VISTA_DetalleDeTerreno vISTA_DetalleDeTerreno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vISTA_DetalleDeTerreno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vISTA_DetalleDeTerreno);
        }

        // GET: VISTA_DetalleDeTerreno/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VISTA_DetalleDeTerreno vISTA_DetalleDeTerreno = db.VISTA_DetalleDeTerreno.Find(id);
            if (vISTA_DetalleDeTerreno == null)
            {
                return HttpNotFound();
            }
            return View(vISTA_DetalleDeTerreno);
        }

        // POST: VISTA_DetalleDeTerreno/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            VISTA_DetalleDeTerreno vISTA_DetalleDeTerreno = db.VISTA_DetalleDeTerreno.Find(id);
            db.VISTA_DetalleDeTerreno.Remove(vISTA_DetalleDeTerreno);
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
