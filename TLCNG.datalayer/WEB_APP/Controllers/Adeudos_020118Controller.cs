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
    public class Adeudos_020118Controller : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: Adeudos_020118
        public ActionResult Index()
        {
            return View(db.Adeudos_020118.ToList());
        }

        // GET: Adeudos_020118/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adeudos_020118 adeudos_020118 = db.Adeudos_020118.Find(id);
            if (adeudos_020118 == null)
            {
                return HttpNotFound();
            }
            return View(adeudos_020118);
        }

        // GET: Adeudos_020118/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Adeudos_020118/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Adeudo,Clave,NumeroDeCuenta,Recargo,Multa,año,DescuentoGeneral,Bimestre1,Bimestre2,Bimestre3,Bimestre4,Bimestre5,Bimestre6,CondonacionGeneral,CondonacionMulta,CondonacionRecargo,BimestresPagados")] Adeudos_020118 adeudos_020118)
        {
            if (ModelState.IsValid)
            {
                db.Adeudos_020118.Add(adeudos_020118);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adeudos_020118);
        }

        // GET: Adeudos_020118/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adeudos_020118 adeudos_020118 = db.Adeudos_020118.Find(id);
            if (adeudos_020118 == null)
            {
                return HttpNotFound();
            }
            return View(adeudos_020118);
        }

        // POST: Adeudos_020118/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Adeudo,Clave,NumeroDeCuenta,Recargo,Multa,año,DescuentoGeneral,Bimestre1,Bimestre2,Bimestre3,Bimestre4,Bimestre5,Bimestre6,CondonacionGeneral,CondonacionMulta,CondonacionRecargo,BimestresPagados")] Adeudos_020118 adeudos_020118)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adeudos_020118).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adeudos_020118);
        }

        // GET: Adeudos_020118/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adeudos_020118 adeudos_020118 = db.Adeudos_020118.Find(id);
            if (adeudos_020118 == null)
            {
                return HttpNotFound();
            }
            return View(adeudos_020118);
        }

        // POST: Adeudos_020118/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Adeudos_020118 adeudos_020118 = db.Adeudos_020118.Find(id);
            db.Adeudos_020118.Remove(adeudos_020118);
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
