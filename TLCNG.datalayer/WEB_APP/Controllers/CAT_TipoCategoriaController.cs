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
    public class CAT_TipoCategoriaController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_TipoCategoria
        public ActionResult Index()
        {
            return View(db.CAT_TipoCategoria.ToList());
        }

        // GET: CAT_TipoCategoria/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoCategoria cAT_TipoCategoria = db.CAT_TipoCategoria.Find(id);
            if (cAT_TipoCategoria == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoCategoria);
        }

        // GET: CAT_TipoCategoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_TipoCategoria/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NombreCategoria")] CAT_TipoCategoria cAT_TipoCategoria)
        {
            if (ModelState.IsValid)
            {
                db.CAT_TipoCategoria.Add(cAT_TipoCategoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_TipoCategoria);
        }

        // GET: CAT_TipoCategoria/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoCategoria cAT_TipoCategoria = db.CAT_TipoCategoria.Find(id);
            if (cAT_TipoCategoria == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoCategoria);
        }

        // POST: CAT_TipoCategoria/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NombreCategoria")] CAT_TipoCategoria cAT_TipoCategoria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_TipoCategoria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_TipoCategoria);
        }

        // GET: CAT_TipoCategoria/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TipoCategoria cAT_TipoCategoria = db.CAT_TipoCategoria.Find(id);
            if (cAT_TipoCategoria == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TipoCategoria);
        }

        // POST: CAT_TipoCategoria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_TipoCategoria cAT_TipoCategoria = db.CAT_TipoCategoria.Find(id);
            db.CAT_TipoCategoria.Remove(cAT_TipoCategoria);
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
