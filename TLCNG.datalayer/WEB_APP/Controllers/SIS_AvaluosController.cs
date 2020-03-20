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
    public class SIS_AvaluosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_Avaluos
        public ActionResult Index()
        {
            return View(db.SIS_Avaluos.ToList());
        }

        // GET: SIS_Avaluos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_Avaluos sIS_Avaluos = db.SIS_Avaluos.Find(id);
            if (sIS_Avaluos == null)
            {
                return HttpNotFound();
            }
            return View(sIS_Avaluos);
        }

        // GET: SIS_Avaluos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_Avaluos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,BaseGravable,AreaTerreno,Municipio,Edificio")] SIS_Avaluos sIS_Avaluos)
        {
            if (ModelState.IsValid)
            {
                db.SIS_Avaluos.Add(sIS_Avaluos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_Avaluos);
        }

        // GET: SIS_Avaluos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_Avaluos sIS_Avaluos = db.SIS_Avaluos.Find(id);
            if (sIS_Avaluos == null)
            {
                return HttpNotFound();
            }
            return View(sIS_Avaluos);
        }

        // POST: SIS_Avaluos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,BaseGravable,AreaTerreno,Municipio,Edificio")] SIS_Avaluos sIS_Avaluos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_Avaluos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_Avaluos);
        }

        // GET: SIS_Avaluos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_Avaluos sIS_Avaluos = db.SIS_Avaluos.Find(id);
            if (sIS_Avaluos == null)
            {
                return HttpNotFound();
            }
            return View(sIS_Avaluos);
        }

        // POST: SIS_Avaluos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_Avaluos sIS_Avaluos = db.SIS_Avaluos.Find(id);
            db.SIS_Avaluos.Remove(sIS_Avaluos);
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
