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
    public class CAT_TRASLADOS_PagoMinimoAvaluoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_TRASLADOS_PagoMinimoAvaluo
        public ActionResult Index()
        {
            return View(db.CAT_TRASLADOS_PagoMinimoAvaluo.ToList());
        }

        // GET: CAT_TRASLADOS_PagoMinimoAvaluo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TRASLADOS_PagoMinimoAvaluo cAT_TRASLADOS_PagoMinimoAvaluo = db.CAT_TRASLADOS_PagoMinimoAvaluo.Find(id);
            if (cAT_TRASLADOS_PagoMinimoAvaluo == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TRASLADOS_PagoMinimoAvaluo);
        }

        // GET: CAT_TRASLADOS_PagoMinimoAvaluo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_TRASLADOS_PagoMinimoAvaluo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,valorMinimoAvaluo,valorPorcentajeAvaluo,descripcion,año,fechaAlta,fechaModificacion")] CAT_TRASLADOS_PagoMinimoAvaluo cAT_TRASLADOS_PagoMinimoAvaluo)
        {
            if (ModelState.IsValid)
            {
                db.CAT_TRASLADOS_PagoMinimoAvaluo.Add(cAT_TRASLADOS_PagoMinimoAvaluo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_TRASLADOS_PagoMinimoAvaluo);
        }

        // GET: CAT_TRASLADOS_PagoMinimoAvaluo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TRASLADOS_PagoMinimoAvaluo cAT_TRASLADOS_PagoMinimoAvaluo = db.CAT_TRASLADOS_PagoMinimoAvaluo.Find(id);
            if (cAT_TRASLADOS_PagoMinimoAvaluo == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TRASLADOS_PagoMinimoAvaluo);
        }

        // POST: CAT_TRASLADOS_PagoMinimoAvaluo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,valorMinimoAvaluo,valorPorcentajeAvaluo,descripcion,año,fechaAlta,fechaModificacion")] CAT_TRASLADOS_PagoMinimoAvaluo cAT_TRASLADOS_PagoMinimoAvaluo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_TRASLADOS_PagoMinimoAvaluo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_TRASLADOS_PagoMinimoAvaluo);
        }

        // GET: CAT_TRASLADOS_PagoMinimoAvaluo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TRASLADOS_PagoMinimoAvaluo cAT_TRASLADOS_PagoMinimoAvaluo = db.CAT_TRASLADOS_PagoMinimoAvaluo.Find(id);
            if (cAT_TRASLADOS_PagoMinimoAvaluo == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TRASLADOS_PagoMinimoAvaluo);
        }

        // POST: CAT_TRASLADOS_PagoMinimoAvaluo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_TRASLADOS_PagoMinimoAvaluo cAT_TRASLADOS_PagoMinimoAvaluo = db.CAT_TRASLADOS_PagoMinimoAvaluo.Find(id);
            db.CAT_TRASLADOS_PagoMinimoAvaluo.Remove(cAT_TRASLADOS_PagoMinimoAvaluo);
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
