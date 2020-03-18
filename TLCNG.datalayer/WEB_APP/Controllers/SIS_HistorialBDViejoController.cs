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
    public class SIS_HistorialBDViejoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_HistorialBDViejo
        public ActionResult Index()
        {
            return View(db.SIS_HistorialBDViejo.ToList());
        }

        // GET: SIS_HistorialBDViejo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialBDViejo sIS_HistorialBDViejo = db.SIS_HistorialBDViejo.Find(id);
            if (sIS_HistorialBDViejo == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialBDViejo);
        }

        // GET: SIS_HistorialBDViejo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_HistorialBDViejo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Clave,NumeroDeCuenta,ClaveCatastral,TipoOperacion,DescripcionOperacion,Usuario,Caja,FechaMovimiento,Nombre,ApellidoP,ApellidoM")] SIS_HistorialBDViejo sIS_HistorialBDViejo)
        {
            if (ModelState.IsValid)
            {
                db.SIS_HistorialBDViejo.Add(sIS_HistorialBDViejo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_HistorialBDViejo);
        }

        // GET: SIS_HistorialBDViejo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialBDViejo sIS_HistorialBDViejo = db.SIS_HistorialBDViejo.Find(id);
            if (sIS_HistorialBDViejo == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialBDViejo);
        }

        // POST: SIS_HistorialBDViejo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Clave,NumeroDeCuenta,ClaveCatastral,TipoOperacion,DescripcionOperacion,Usuario,Caja,FechaMovimiento,Nombre,ApellidoP,ApellidoM")] SIS_HistorialBDViejo sIS_HistorialBDViejo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_HistorialBDViejo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_HistorialBDViejo);
        }

        // GET: SIS_HistorialBDViejo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialBDViejo sIS_HistorialBDViejo = db.SIS_HistorialBDViejo.Find(id);
            if (sIS_HistorialBDViejo == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialBDViejo);
        }

        // POST: SIS_HistorialBDViejo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_HistorialBDViejo sIS_HistorialBDViejo = db.SIS_HistorialBDViejo.Find(id);
            db.SIS_HistorialBDViejo.Remove(sIS_HistorialBDViejo);
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
