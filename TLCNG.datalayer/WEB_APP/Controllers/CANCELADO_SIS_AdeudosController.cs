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
    public class CANCELADO_SIS_AdeudosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CANCELADO_SIS_Adeudos
        public ActionResult Index()
        {
            return View(db.CANCELADO_SIS_Adeudos.ToList());
        }

        // GET: CANCELADO_SIS_Adeudos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_Adeudos cANCELADO_SIS_Adeudos = db.CANCELADO_SIS_Adeudos.Find(id);
            if (cANCELADO_SIS_Adeudos == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_Adeudos);
        }

        // GET: CANCELADO_SIS_Adeudos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CANCELADO_SIS_Adeudos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Adeudo,Clave,NumeroDeCuenta,Recargo,Multa,año,DescuentoGeneral,Bimestre1,Bimestre2,Bimestre3,Bimestre4,Bimestre5,Bimestre6,CondonacionGeneral,CondonacionMulta,CondonacionRecargo,BimestresPagados")] CANCELADO_SIS_Adeudos cANCELADO_SIS_Adeudos)
        {
            if (ModelState.IsValid)
            {
                db.CANCELADO_SIS_Adeudos.Add(cANCELADO_SIS_Adeudos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cANCELADO_SIS_Adeudos);
        }

        // GET: CANCELADO_SIS_Adeudos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_Adeudos cANCELADO_SIS_Adeudos = db.CANCELADO_SIS_Adeudos.Find(id);
            if (cANCELADO_SIS_Adeudos == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_Adeudos);
        }

        // POST: CANCELADO_SIS_Adeudos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Adeudo,Clave,NumeroDeCuenta,Recargo,Multa,año,DescuentoGeneral,Bimestre1,Bimestre2,Bimestre3,Bimestre4,Bimestre5,Bimestre6,CondonacionGeneral,CondonacionMulta,CondonacionRecargo,BimestresPagados")] CANCELADO_SIS_Adeudos cANCELADO_SIS_Adeudos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cANCELADO_SIS_Adeudos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cANCELADO_SIS_Adeudos);
        }

        // GET: CANCELADO_SIS_Adeudos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_Adeudos cANCELADO_SIS_Adeudos = db.CANCELADO_SIS_Adeudos.Find(id);
            if (cANCELADO_SIS_Adeudos == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_Adeudos);
        }

        // POST: CANCELADO_SIS_Adeudos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CANCELADO_SIS_Adeudos cANCELADO_SIS_Adeudos = db.CANCELADO_SIS_Adeudos.Find(id);
            db.CANCELADO_SIS_Adeudos.Remove(cANCELADO_SIS_Adeudos);
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
