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
    public class RESP_SIS_DetallesDeTerrenoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: RESP_SIS_DetallesDeTerreno
        public ActionResult Index()
        {
            return View(db.RESP_SIS_DetallesDeTerreno.ToList());
        }

        // GET: RESP_SIS_DetallesDeTerreno/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RESP_SIS_DetallesDeTerreno rESP_SIS_DetallesDeTerreno = db.RESP_SIS_DetallesDeTerreno.Find(id);
            if (rESP_SIS_DetallesDeTerreno == null)
            {
                return HttpNotFound();
            }
            return View(rESP_SIS_DetallesDeTerreno);
        }

        // GET: RESP_SIS_DetallesDeTerreno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RESP_SIS_DetallesDeTerreno/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,AreaConstruccion,UsoDeSuelo,IdTipoDeConstruccion,Municipio,Edificio")] RESP_SIS_DetallesDeTerreno rESP_SIS_DetallesDeTerreno)
        {
            if (ModelState.IsValid)
            {
                db.RESP_SIS_DetallesDeTerreno.Add(rESP_SIS_DetallesDeTerreno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rESP_SIS_DetallesDeTerreno);
        }

        // GET: RESP_SIS_DetallesDeTerreno/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RESP_SIS_DetallesDeTerreno rESP_SIS_DetallesDeTerreno = db.RESP_SIS_DetallesDeTerreno.Find(id);
            if (rESP_SIS_DetallesDeTerreno == null)
            {
                return HttpNotFound();
            }
            return View(rESP_SIS_DetallesDeTerreno);
        }

        // POST: RESP_SIS_DetallesDeTerreno/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,Año,AreaConstruccion,UsoDeSuelo,IdTipoDeConstruccion,Municipio,Edificio")] RESP_SIS_DetallesDeTerreno rESP_SIS_DetallesDeTerreno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rESP_SIS_DetallesDeTerreno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rESP_SIS_DetallesDeTerreno);
        }

        // GET: RESP_SIS_DetallesDeTerreno/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RESP_SIS_DetallesDeTerreno rESP_SIS_DetallesDeTerreno = db.RESP_SIS_DetallesDeTerreno.Find(id);
            if (rESP_SIS_DetallesDeTerreno == null)
            {
                return HttpNotFound();
            }
            return View(rESP_SIS_DetallesDeTerreno);
        }

        // POST: RESP_SIS_DetallesDeTerreno/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RESP_SIS_DetallesDeTerreno rESP_SIS_DetallesDeTerreno = db.RESP_SIS_DetallesDeTerreno.Find(id);
            db.RESP_SIS_DetallesDeTerreno.Remove(rESP_SIS_DetallesDeTerreno);
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
