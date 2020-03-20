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
    public class CANCELADO_SIS_AvaluosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CANCELADO_SIS_Avaluos
        public ActionResult Index()
        {
            return View(db.CANCELADO_SIS_Avaluos.ToList());
        }

        // GET: CANCELADO_SIS_Avaluos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_Avaluos cANCELADO_SIS_Avaluos = db.CANCELADO_SIS_Avaluos.Find(id);
            if (cANCELADO_SIS_Avaluos == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_Avaluos);
        }

        // GET: CANCELADO_SIS_Avaluos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CANCELADO_SIS_Avaluos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,BaseGravable,AreaTerreno,Municipio,Edificio")] CANCELADO_SIS_Avaluos cANCELADO_SIS_Avaluos)
        {
            if (ModelState.IsValid)
            {
                db.CANCELADO_SIS_Avaluos.Add(cANCELADO_SIS_Avaluos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cANCELADO_SIS_Avaluos);
        }

        // GET: CANCELADO_SIS_Avaluos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_Avaluos cANCELADO_SIS_Avaluos = db.CANCELADO_SIS_Avaluos.Find(id);
            if (cANCELADO_SIS_Avaluos == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_Avaluos);
        }

        // POST: CANCELADO_SIS_Avaluos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,BaseGravable,AreaTerreno,Municipio,Edificio")] CANCELADO_SIS_Avaluos cANCELADO_SIS_Avaluos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cANCELADO_SIS_Avaluos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cANCELADO_SIS_Avaluos);
        }

        // GET: CANCELADO_SIS_Avaluos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_Avaluos cANCELADO_SIS_Avaluos = db.CANCELADO_SIS_Avaluos.Find(id);
            if (cANCELADO_SIS_Avaluos == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_Avaluos);
        }

        // POST: CANCELADO_SIS_Avaluos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CANCELADO_SIS_Avaluos cANCELADO_SIS_Avaluos = db.CANCELADO_SIS_Avaluos.Find(id);
            db.CANCELADO_SIS_Avaluos.Remove(cANCELADO_SIS_Avaluos);
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
