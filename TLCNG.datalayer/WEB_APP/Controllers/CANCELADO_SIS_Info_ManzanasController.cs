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
    public class CANCELADO_SIS_Info_ManzanasController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CANCELADO_SIS_Info_Manzanas
        public ActionResult Index()
        {
            return View(db.CANCELADO_SIS_Info_Manzanas.ToList());
        }

        // GET: CANCELADO_SIS_Info_Manzanas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_Info_Manzanas cANCELADO_SIS_Info_Manzanas = db.CANCELADO_SIS_Info_Manzanas.Find(id);
            if (cANCELADO_SIS_Info_Manzanas == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_Info_Manzanas);
        }

        // GET: CANCELADO_SIS_Info_Manzanas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CANCELADO_SIS_Info_Manzanas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Clave,NumeroDeCuenta,Manzana,Lote,Parcela,Zona")] CANCELADO_SIS_Info_Manzanas cANCELADO_SIS_Info_Manzanas)
        {
            if (ModelState.IsValid)
            {
                db.CANCELADO_SIS_Info_Manzanas.Add(cANCELADO_SIS_Info_Manzanas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cANCELADO_SIS_Info_Manzanas);
        }

        // GET: CANCELADO_SIS_Info_Manzanas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_Info_Manzanas cANCELADO_SIS_Info_Manzanas = db.CANCELADO_SIS_Info_Manzanas.Find(id);
            if (cANCELADO_SIS_Info_Manzanas == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_Info_Manzanas);
        }

        // POST: CANCELADO_SIS_Info_Manzanas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Clave,NumeroDeCuenta,Manzana,Lote,Parcela,Zona")] CANCELADO_SIS_Info_Manzanas cANCELADO_SIS_Info_Manzanas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cANCELADO_SIS_Info_Manzanas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cANCELADO_SIS_Info_Manzanas);
        }

        // GET: CANCELADO_SIS_Info_Manzanas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_Info_Manzanas cANCELADO_SIS_Info_Manzanas = db.CANCELADO_SIS_Info_Manzanas.Find(id);
            if (cANCELADO_SIS_Info_Manzanas == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_Info_Manzanas);
        }

        // POST: CANCELADO_SIS_Info_Manzanas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CANCELADO_SIS_Info_Manzanas cANCELADO_SIS_Info_Manzanas = db.CANCELADO_SIS_Info_Manzanas.Find(id);
            db.CANCELADO_SIS_Info_Manzanas.Remove(cANCELADO_SIS_Info_Manzanas);
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
