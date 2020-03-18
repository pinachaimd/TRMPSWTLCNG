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
    public class SIS_AñosGeneradosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_AñosGenerados
        public ActionResult Index()
        {
            return View(db.SIS_AñosGenerados.ToList());
        }

        // GET: SIS_AñosGenerados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_AñosGenerados sIS_AñosGenerados = db.SIS_AñosGenerados.Find(id);
            if (sIS_AñosGenerados == null)
            {
                return HttpNotFound();
            }
            return View(sIS_AñosGenerados);
        }

        // GET: SIS_AñosGenerados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_AñosGenerados/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Año,Procesado,Id")] SIS_AñosGenerados sIS_AñosGenerados)
        {
            if (ModelState.IsValid)
            {
                db.SIS_AñosGenerados.Add(sIS_AñosGenerados);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_AñosGenerados);
        }

        // GET: SIS_AñosGenerados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_AñosGenerados sIS_AñosGenerados = db.SIS_AñosGenerados.Find(id);
            if (sIS_AñosGenerados == null)
            {
                return HttpNotFound();
            }
            return View(sIS_AñosGenerados);
        }

        // POST: SIS_AñosGenerados/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Año,Procesado,Id")] SIS_AñosGenerados sIS_AñosGenerados)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_AñosGenerados).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_AñosGenerados);
        }

        // GET: SIS_AñosGenerados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_AñosGenerados sIS_AñosGenerados = db.SIS_AñosGenerados.Find(id);
            if (sIS_AñosGenerados == null)
            {
                return HttpNotFound();
            }
            return View(sIS_AñosGenerados);
        }

        // POST: SIS_AñosGenerados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_AñosGenerados sIS_AñosGenerados = db.SIS_AñosGenerados.Find(id);
            db.SIS_AñosGenerados.Remove(sIS_AñosGenerados);
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
