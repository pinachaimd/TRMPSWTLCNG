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
    public class CANCELADO_SIS_NotaController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CANCELADO_SIS_Nota
        public ActionResult Index()
        {
            return View(db.CANCELADO_SIS_Nota.ToList());
        }

        // GET: CANCELADO_SIS_Nota/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_Nota cANCELADO_SIS_Nota = db.CANCELADO_SIS_Nota.Find(id);
            if (cANCELADO_SIS_Nota == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_Nota);
        }

        // GET: CANCELADO_SIS_Nota/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CANCELADO_SIS_Nota/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,tipoNota,clave,numeroDeCuenta,idColonia,manzana,nota,fecha")] CANCELADO_SIS_Nota cANCELADO_SIS_Nota)
        {
            if (ModelState.IsValid)
            {
                db.CANCELADO_SIS_Nota.Add(cANCELADO_SIS_Nota);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cANCELADO_SIS_Nota);
        }

        // GET: CANCELADO_SIS_Nota/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_Nota cANCELADO_SIS_Nota = db.CANCELADO_SIS_Nota.Find(id);
            if (cANCELADO_SIS_Nota == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_Nota);
        }

        // POST: CANCELADO_SIS_Nota/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,tipoNota,clave,numeroDeCuenta,idColonia,manzana,nota,fecha")] CANCELADO_SIS_Nota cANCELADO_SIS_Nota)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cANCELADO_SIS_Nota).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cANCELADO_SIS_Nota);
        }

        // GET: CANCELADO_SIS_Nota/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_Nota cANCELADO_SIS_Nota = db.CANCELADO_SIS_Nota.Find(id);
            if (cANCELADO_SIS_Nota == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_Nota);
        }

        // POST: CANCELADO_SIS_Nota/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            CANCELADO_SIS_Nota cANCELADO_SIS_Nota = db.CANCELADO_SIS_Nota.Find(id);
            db.CANCELADO_SIS_Nota.Remove(cANCELADO_SIS_Nota);
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
