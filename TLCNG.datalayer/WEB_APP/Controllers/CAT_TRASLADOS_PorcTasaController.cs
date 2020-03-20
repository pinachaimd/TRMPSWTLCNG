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
    public class CAT_TRASLADOS_PorcTasaController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_TRASLADOS_PorcTasa
        public ActionResult Index()
        {
            return View(db.CAT_TRASLADOS_PorcTasa.ToList());
        }

        // GET: CAT_TRASLADOS_PorcTasa/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TRASLADOS_PorcTasa cAT_TRASLADOS_PorcTasa = db.CAT_TRASLADOS_PorcTasa.Find(id);
            if (cAT_TRASLADOS_PorcTasa == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TRASLADOS_PorcTasa);
        }

        // GET: CAT_TRASLADOS_PorcTasa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_TRASLADOS_PorcTasa/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,porcentaje,Nombre")] CAT_TRASLADOS_PorcTasa cAT_TRASLADOS_PorcTasa)
        {
            if (ModelState.IsValid)
            {
                db.CAT_TRASLADOS_PorcTasa.Add(cAT_TRASLADOS_PorcTasa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_TRASLADOS_PorcTasa);
        }

        // GET: CAT_TRASLADOS_PorcTasa/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TRASLADOS_PorcTasa cAT_TRASLADOS_PorcTasa = db.CAT_TRASLADOS_PorcTasa.Find(id);
            if (cAT_TRASLADOS_PorcTasa == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TRASLADOS_PorcTasa);
        }

        // POST: CAT_TRASLADOS_PorcTasa/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,porcentaje,Nombre")] CAT_TRASLADOS_PorcTasa cAT_TRASLADOS_PorcTasa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_TRASLADOS_PorcTasa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_TRASLADOS_PorcTasa);
        }

        // GET: CAT_TRASLADOS_PorcTasa/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TRASLADOS_PorcTasa cAT_TRASLADOS_PorcTasa = db.CAT_TRASLADOS_PorcTasa.Find(id);
            if (cAT_TRASLADOS_PorcTasa == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TRASLADOS_PorcTasa);
        }

        // POST: CAT_TRASLADOS_PorcTasa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_TRASLADOS_PorcTasa cAT_TRASLADOS_PorcTasa = db.CAT_TRASLADOS_PorcTasa.Find(id);
            db.CAT_TRASLADOS_PorcTasa.Remove(cAT_TRASLADOS_PorcTasa);
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
