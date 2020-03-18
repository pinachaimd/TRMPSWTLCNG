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
    public class SIS_Info_ManzanasController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_Info_Manzanas
        public ActionResult Index()
        {
            return View(db.SIS_Info_Manzanas.ToList());
        }

        // GET: SIS_Info_Manzanas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_Info_Manzanas sIS_Info_Manzanas = db.SIS_Info_Manzanas.Find(id);
            if (sIS_Info_Manzanas == null)
            {
                return HttpNotFound();
            }
            return View(sIS_Info_Manzanas);
        }

        // GET: SIS_Info_Manzanas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_Info_Manzanas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Clave,NumeroDeCuenta,Manzana,Lote,Parcela,Zona")] SIS_Info_Manzanas sIS_Info_Manzanas)
        {
            if (ModelState.IsValid)
            {
                db.SIS_Info_Manzanas.Add(sIS_Info_Manzanas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_Info_Manzanas);
        }

        // GET: SIS_Info_Manzanas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_Info_Manzanas sIS_Info_Manzanas = db.SIS_Info_Manzanas.Find(id);
            if (sIS_Info_Manzanas == null)
            {
                return HttpNotFound();
            }
            return View(sIS_Info_Manzanas);
        }

        // POST: SIS_Info_Manzanas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Clave,NumeroDeCuenta,Manzana,Lote,Parcela,Zona")] SIS_Info_Manzanas sIS_Info_Manzanas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_Info_Manzanas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_Info_Manzanas);
        }

        // GET: SIS_Info_Manzanas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_Info_Manzanas sIS_Info_Manzanas = db.SIS_Info_Manzanas.Find(id);
            if (sIS_Info_Manzanas == null)
            {
                return HttpNotFound();
            }
            return View(sIS_Info_Manzanas);
        }

        // POST: SIS_Info_Manzanas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_Info_Manzanas sIS_Info_Manzanas = db.SIS_Info_Manzanas.Find(id);
            db.SIS_Info_Manzanas.Remove(sIS_Info_Manzanas);
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
