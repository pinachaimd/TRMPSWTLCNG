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
    public class TRA_ParametrosLeyDeIngresosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: TRA_ParametrosLeyDeIngresos
        public ActionResult Index()
        {
            return View(db.TRA_ParametrosLeyDeIngresos.ToList());
        }

        // GET: TRA_ParametrosLeyDeIngresos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_ParametrosLeyDeIngresos tRA_ParametrosLeyDeIngresos = db.TRA_ParametrosLeyDeIngresos.Find(id);
            if (tRA_ParametrosLeyDeIngresos == null)
            {
                return HttpNotFound();
            }
            return View(tRA_ParametrosLeyDeIngresos);
        }

        // GET: TRA_ParametrosLeyDeIngresos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TRA_ParametrosLeyDeIngresos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,año,porceTraslado,porceRecargo,salariominimo,RecargoExtra")] TRA_ParametrosLeyDeIngresos tRA_ParametrosLeyDeIngresos)
        {
            if (ModelState.IsValid)
            {
                db.TRA_ParametrosLeyDeIngresos.Add(tRA_ParametrosLeyDeIngresos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tRA_ParametrosLeyDeIngresos);
        }

        // GET: TRA_ParametrosLeyDeIngresos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_ParametrosLeyDeIngresos tRA_ParametrosLeyDeIngresos = db.TRA_ParametrosLeyDeIngresos.Find(id);
            if (tRA_ParametrosLeyDeIngresos == null)
            {
                return HttpNotFound();
            }
            return View(tRA_ParametrosLeyDeIngresos);
        }

        // POST: TRA_ParametrosLeyDeIngresos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,año,porceTraslado,porceRecargo,salariominimo,RecargoExtra")] TRA_ParametrosLeyDeIngresos tRA_ParametrosLeyDeIngresos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tRA_ParametrosLeyDeIngresos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tRA_ParametrosLeyDeIngresos);
        }

        // GET: TRA_ParametrosLeyDeIngresos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_ParametrosLeyDeIngresos tRA_ParametrosLeyDeIngresos = db.TRA_ParametrosLeyDeIngresos.Find(id);
            if (tRA_ParametrosLeyDeIngresos == null)
            {
                return HttpNotFound();
            }
            return View(tRA_ParametrosLeyDeIngresos);
        }

        // POST: TRA_ParametrosLeyDeIngresos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TRA_ParametrosLeyDeIngresos tRA_ParametrosLeyDeIngresos = db.TRA_ParametrosLeyDeIngresos.Find(id);
            db.TRA_ParametrosLeyDeIngresos.Remove(tRA_ParametrosLeyDeIngresos);
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
