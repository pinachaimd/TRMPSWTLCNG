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
    public class CAT_JefesDepartamentosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_JefesDepartamentos
        public ActionResult Index()
        {
            return View(db.CAT_JefesDepartamentos.ToList());
        }

        // GET: CAT_JefesDepartamentos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_JefesDepartamentos cAT_JefesDepartamentos = db.CAT_JefesDepartamentos.Find(id);
            if (cAT_JefesDepartamentos == null)
            {
                return HttpNotFound();
            }
            return View(cAT_JefesDepartamentos);
        }

        // GET: CAT_JefesDepartamentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_JefesDepartamentos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombreDepartamento,nombreDirector,apellidoPaternoDirector,apellidoMaternoDirector,abreviaturaPuesto")] CAT_JefesDepartamentos cAT_JefesDepartamentos)
        {
            if (ModelState.IsValid)
            {
                db.CAT_JefesDepartamentos.Add(cAT_JefesDepartamentos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_JefesDepartamentos);
        }

        // GET: CAT_JefesDepartamentos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_JefesDepartamentos cAT_JefesDepartamentos = db.CAT_JefesDepartamentos.Find(id);
            if (cAT_JefesDepartamentos == null)
            {
                return HttpNotFound();
            }
            return View(cAT_JefesDepartamentos);
        }

        // POST: CAT_JefesDepartamentos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombreDepartamento,nombreDirector,apellidoPaternoDirector,apellidoMaternoDirector,abreviaturaPuesto")] CAT_JefesDepartamentos cAT_JefesDepartamentos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_JefesDepartamentos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_JefesDepartamentos);
        }

        // GET: CAT_JefesDepartamentos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_JefesDepartamentos cAT_JefesDepartamentos = db.CAT_JefesDepartamentos.Find(id);
            if (cAT_JefesDepartamentos == null)
            {
                return HttpNotFound();
            }
            return View(cAT_JefesDepartamentos);
        }

        // POST: CAT_JefesDepartamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_JefesDepartamentos cAT_JefesDepartamentos = db.CAT_JefesDepartamentos.Find(id);
            db.CAT_JefesDepartamentos.Remove(cAT_JefesDepartamentos);
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
