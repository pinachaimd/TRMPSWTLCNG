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
    public class SIS_AdeudosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_Adeudos
        public ActionResult Index()
        {
            return View(db.SIS_Adeudos.ToList());
        }

        // GET: SIS_Adeudos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_Adeudos sIS_Adeudos = db.SIS_Adeudos.Find(id);
            if (sIS_Adeudos == null)
            {
                return HttpNotFound();
            }
            return View(sIS_Adeudos);
        }

        // GET: SIS_Adeudos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_Adeudos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Adeudo,Clave,NumeroDeCuenta,Recargo,Multa,año,DescuentoGeneral,Bimestre1,Bimestre2,Bimestre3,Bimestre4,Bimestre5,Bimestre6,CondonacionGeneral,CondonacionMulta,CondonacionRecargo,BimestresPagados")] SIS_Adeudos sIS_Adeudos)
        {
            if (ModelState.IsValid)
            {
                db.SIS_Adeudos.Add(sIS_Adeudos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_Adeudos);
        }

        // GET: SIS_Adeudos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_Adeudos sIS_Adeudos = db.SIS_Adeudos.Find(id);
            if (sIS_Adeudos == null)
            {
                return HttpNotFound();
            }
            return View(sIS_Adeudos);
        }

        // POST: SIS_Adeudos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Adeudo,Clave,NumeroDeCuenta,Recargo,Multa,año,DescuentoGeneral,Bimestre1,Bimestre2,Bimestre3,Bimestre4,Bimestre5,Bimestre6,CondonacionGeneral,CondonacionMulta,CondonacionRecargo,BimestresPagados")] SIS_Adeudos sIS_Adeudos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_Adeudos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_Adeudos);
        }

        // GET: SIS_Adeudos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_Adeudos sIS_Adeudos = db.SIS_Adeudos.Find(id);
            if (sIS_Adeudos == null)
            {
                return HttpNotFound();
            }
            return View(sIS_Adeudos);
        }

        // POST: SIS_Adeudos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_Adeudos sIS_Adeudos = db.SIS_Adeudos.Find(id);
            db.SIS_Adeudos.Remove(sIS_Adeudos);
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
