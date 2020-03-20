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
    public class INCONSISTENCIAS_CATASTRO_ADEUDOSController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: INCONSISTENCIAS_CATASTRO_ADEUDOS
        public ActionResult Index()
        {
            return View(db.INCONSISTENCIAS_CATASTRO_ADEUDOS.ToList());
        }

        // GET: INCONSISTENCIAS_CATASTRO_ADEUDOS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            INCONSISTENCIAS_CATASTRO_ADEUDOS iNCONSISTENCIAS_CATASTRO_ADEUDOS = db.INCONSISTENCIAS_CATASTRO_ADEUDOS.Find(id);
            if (iNCONSISTENCIAS_CATASTRO_ADEUDOS == null)
            {
                return HttpNotFound();
            }
            return View(iNCONSISTENCIAS_CATASTRO_ADEUDOS);
        }

        // GET: INCONSISTENCIAS_CATASTRO_ADEUDOS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: INCONSISTENCIAS_CATASTRO_ADEUDOS/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Adeudo,Clave,NumeroDeCuenta,Recargo,Multa,año,DescuentoGeneral,Bimestre1,Bimestre2,Bimestre3,Bimestre4,Bimestre5,Bimestre6,CondonacionGeneral,CondonacionMulta,CondonacionRecargo,BimestresPagados")] INCONSISTENCIAS_CATASTRO_ADEUDOS iNCONSISTENCIAS_CATASTRO_ADEUDOS)
        {
            if (ModelState.IsValid)
            {
                db.INCONSISTENCIAS_CATASTRO_ADEUDOS.Add(iNCONSISTENCIAS_CATASTRO_ADEUDOS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(iNCONSISTENCIAS_CATASTRO_ADEUDOS);
        }

        // GET: INCONSISTENCIAS_CATASTRO_ADEUDOS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            INCONSISTENCIAS_CATASTRO_ADEUDOS iNCONSISTENCIAS_CATASTRO_ADEUDOS = db.INCONSISTENCIAS_CATASTRO_ADEUDOS.Find(id);
            if (iNCONSISTENCIAS_CATASTRO_ADEUDOS == null)
            {
                return HttpNotFound();
            }
            return View(iNCONSISTENCIAS_CATASTRO_ADEUDOS);
        }

        // POST: INCONSISTENCIAS_CATASTRO_ADEUDOS/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Adeudo,Clave,NumeroDeCuenta,Recargo,Multa,año,DescuentoGeneral,Bimestre1,Bimestre2,Bimestre3,Bimestre4,Bimestre5,Bimestre6,CondonacionGeneral,CondonacionMulta,CondonacionRecargo,BimestresPagados")] INCONSISTENCIAS_CATASTRO_ADEUDOS iNCONSISTENCIAS_CATASTRO_ADEUDOS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iNCONSISTENCIAS_CATASTRO_ADEUDOS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(iNCONSISTENCIAS_CATASTRO_ADEUDOS);
        }

        // GET: INCONSISTENCIAS_CATASTRO_ADEUDOS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            INCONSISTENCIAS_CATASTRO_ADEUDOS iNCONSISTENCIAS_CATASTRO_ADEUDOS = db.INCONSISTENCIAS_CATASTRO_ADEUDOS.Find(id);
            if (iNCONSISTENCIAS_CATASTRO_ADEUDOS == null)
            {
                return HttpNotFound();
            }
            return View(iNCONSISTENCIAS_CATASTRO_ADEUDOS);
        }

        // POST: INCONSISTENCIAS_CATASTRO_ADEUDOS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            INCONSISTENCIAS_CATASTRO_ADEUDOS iNCONSISTENCIAS_CATASTRO_ADEUDOS = db.INCONSISTENCIAS_CATASTRO_ADEUDOS.Find(id);
            db.INCONSISTENCIAS_CATASTRO_ADEUDOS.Remove(iNCONSISTENCIAS_CATASTRO_ADEUDOS);
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
