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
    public class SIS_Adeudos_TemporalController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_Adeudos_Temporal
        public ActionResult Index()
        {
            return View(db.SIS_Adeudos_Temporal.ToList());
        }

        // GET: SIS_Adeudos_Temporal/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_Adeudos_Temporal sIS_Adeudos_Temporal = db.SIS_Adeudos_Temporal.Find(id);
            if (sIS_Adeudos_Temporal == null)
            {
                return HttpNotFound();
            }
            return View(sIS_Adeudos_Temporal);
        }

        // GET: SIS_Adeudos_Temporal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_Adeudos_Temporal/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Adeudo,Clave,NumeroDeCuenta,Recargo,Multa,año,DescuentoGeneral,Bimestre1,Bimestre2,Bimestre3,Bimestre4,Bimestre5,Bimestre6,CondonacionGeneral,CondonacionMulta,CondonacionRecargo,BimestresPagados")] SIS_Adeudos_Temporal sIS_Adeudos_Temporal)
        {
            if (ModelState.IsValid)
            {
                db.SIS_Adeudos_Temporal.Add(sIS_Adeudos_Temporal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_Adeudos_Temporal);
        }

        // GET: SIS_Adeudos_Temporal/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_Adeudos_Temporal sIS_Adeudos_Temporal = db.SIS_Adeudos_Temporal.Find(id);
            if (sIS_Adeudos_Temporal == null)
            {
                return HttpNotFound();
            }
            return View(sIS_Adeudos_Temporal);
        }

        // POST: SIS_Adeudos_Temporal/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Adeudo,Clave,NumeroDeCuenta,Recargo,Multa,año,DescuentoGeneral,Bimestre1,Bimestre2,Bimestre3,Bimestre4,Bimestre5,Bimestre6,CondonacionGeneral,CondonacionMulta,CondonacionRecargo,BimestresPagados")] SIS_Adeudos_Temporal sIS_Adeudos_Temporal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_Adeudos_Temporal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_Adeudos_Temporal);
        }

        // GET: SIS_Adeudos_Temporal/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_Adeudos_Temporal sIS_Adeudos_Temporal = db.SIS_Adeudos_Temporal.Find(id);
            if (sIS_Adeudos_Temporal == null)
            {
                return HttpNotFound();
            }
            return View(sIS_Adeudos_Temporal);
        }

        // POST: SIS_Adeudos_Temporal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_Adeudos_Temporal sIS_Adeudos_Temporal = db.SIS_Adeudos_Temporal.Find(id);
            db.SIS_Adeudos_Temporal.Remove(sIS_Adeudos_Temporal);
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
