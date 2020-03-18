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
    public class SIS_HistorialAdeudoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_HistorialAdeudo
        public ActionResult Index()
        {
            return View(db.SIS_HistorialAdeudo.ToList());
        }

        // GET: SIS_HistorialAdeudo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialAdeudo sIS_HistorialAdeudo = db.SIS_HistorialAdeudo.Find(id);
            if (sIS_HistorialAdeudo == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialAdeudo);
        }

        // GET: SIS_HistorialAdeudo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_HistorialAdeudo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Adeudo,Clave,NumeroDeCuenta,Recargo,Multa,año,DescuentoGeneral,Bimestre1,Bimestre2,Bimestre3,Bimestre4,Bimestre5,Bimestre6,CondonacionGeneral,CondonacionMulta,CondonacionRecargo,FechaDeAplicacion")] SIS_HistorialAdeudo sIS_HistorialAdeudo)
        {
            if (ModelState.IsValid)
            {
                db.SIS_HistorialAdeudo.Add(sIS_HistorialAdeudo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_HistorialAdeudo);
        }

        // GET: SIS_HistorialAdeudo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialAdeudo sIS_HistorialAdeudo = db.SIS_HistorialAdeudo.Find(id);
            if (sIS_HistorialAdeudo == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialAdeudo);
        }

        // POST: SIS_HistorialAdeudo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Adeudo,Clave,NumeroDeCuenta,Recargo,Multa,año,DescuentoGeneral,Bimestre1,Bimestre2,Bimestre3,Bimestre4,Bimestre5,Bimestre6,CondonacionGeneral,CondonacionMulta,CondonacionRecargo,FechaDeAplicacion")] SIS_HistorialAdeudo sIS_HistorialAdeudo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_HistorialAdeudo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_HistorialAdeudo);
        }

        // GET: SIS_HistorialAdeudo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialAdeudo sIS_HistorialAdeudo = db.SIS_HistorialAdeudo.Find(id);
            if (sIS_HistorialAdeudo == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialAdeudo);
        }

        // POST: SIS_HistorialAdeudo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_HistorialAdeudo sIS_HistorialAdeudo = db.SIS_HistorialAdeudo.Find(id);
            db.SIS_HistorialAdeudo.Remove(sIS_HistorialAdeudo);
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
