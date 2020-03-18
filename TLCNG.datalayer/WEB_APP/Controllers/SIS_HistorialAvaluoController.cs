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
    public class SIS_HistorialAvaluoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_HistorialAvaluo
        public ActionResult Index()
        {
            return View(db.SIS_HistorialAvaluo.ToList());
        }

        // GET: SIS_HistorialAvaluo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialAvaluo sIS_HistorialAvaluo = db.SIS_HistorialAvaluo.Find(id);
            if (sIS_HistorialAvaluo == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialAvaluo);
        }

        // GET: SIS_HistorialAvaluo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_HistorialAvaluo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,BaseGravable,AreaTerreno,Municipio,Edificio,ClaveOrigen,NumeroDeCuentaOrigen")] SIS_HistorialAvaluo sIS_HistorialAvaluo)
        {
            if (ModelState.IsValid)
            {
                db.SIS_HistorialAvaluo.Add(sIS_HistorialAvaluo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_HistorialAvaluo);
        }

        // GET: SIS_HistorialAvaluo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialAvaluo sIS_HistorialAvaluo = db.SIS_HistorialAvaluo.Find(id);
            if (sIS_HistorialAvaluo == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialAvaluo);
        }

        // POST: SIS_HistorialAvaluo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,BaseGravable,AreaTerreno,Municipio,Edificio,ClaveOrigen,NumeroDeCuentaOrigen")] SIS_HistorialAvaluo sIS_HistorialAvaluo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_HistorialAvaluo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_HistorialAvaluo);
        }

        // GET: SIS_HistorialAvaluo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialAvaluo sIS_HistorialAvaluo = db.SIS_HistorialAvaluo.Find(id);
            if (sIS_HistorialAvaluo == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialAvaluo);
        }

        // POST: SIS_HistorialAvaluo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_HistorialAvaluo sIS_HistorialAvaluo = db.SIS_HistorialAvaluo.Find(id);
            db.SIS_HistorialAvaluo.Remove(sIS_HistorialAvaluo);
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
