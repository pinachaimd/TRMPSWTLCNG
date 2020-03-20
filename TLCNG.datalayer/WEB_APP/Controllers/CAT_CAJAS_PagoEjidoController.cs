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
    public class CAT_CAJAS_PagoEjidoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_CAJAS_PagoEjido
        public ActionResult Index()
        {
            return View(db.CAT_CAJAS_PagoEjido.ToList());
        }

        // GET: CAT_CAJAS_PagoEjido/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_CAJAS_PagoEjido cAT_CAJAS_PagoEjido = db.CAT_CAJAS_PagoEjido.Find(id);
            if (cAT_CAJAS_PagoEjido == null)
            {
                return HttpNotFound();
            }
            return View(cAT_CAJAS_PagoEjido);
        }

        // GET: CAT_CAJAS_PagoEjido/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_CAJAS_PagoEjido/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,valor,descripcion,año,fechaAlta,fechaModificacion")] CAT_CAJAS_PagoEjido cAT_CAJAS_PagoEjido)
        {
            if (ModelState.IsValid)
            {
                db.CAT_CAJAS_PagoEjido.Add(cAT_CAJAS_PagoEjido);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_CAJAS_PagoEjido);
        }

        // GET: CAT_CAJAS_PagoEjido/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_CAJAS_PagoEjido cAT_CAJAS_PagoEjido = db.CAT_CAJAS_PagoEjido.Find(id);
            if (cAT_CAJAS_PagoEjido == null)
            {
                return HttpNotFound();
            }
            return View(cAT_CAJAS_PagoEjido);
        }

        // POST: CAT_CAJAS_PagoEjido/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,valor,descripcion,año,fechaAlta,fechaModificacion")] CAT_CAJAS_PagoEjido cAT_CAJAS_PagoEjido)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_CAJAS_PagoEjido).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_CAJAS_PagoEjido);
        }

        // GET: CAT_CAJAS_PagoEjido/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_CAJAS_PagoEjido cAT_CAJAS_PagoEjido = db.CAT_CAJAS_PagoEjido.Find(id);
            if (cAT_CAJAS_PagoEjido == null)
            {
                return HttpNotFound();
            }
            return View(cAT_CAJAS_PagoEjido);
        }

        // POST: CAT_CAJAS_PagoEjido/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_CAJAS_PagoEjido cAT_CAJAS_PagoEjido = db.CAT_CAJAS_PagoEjido.Find(id);
            db.CAT_CAJAS_PagoEjido.Remove(cAT_CAJAS_PagoEjido);
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
