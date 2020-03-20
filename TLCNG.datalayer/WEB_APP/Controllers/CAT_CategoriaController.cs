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
    public class CAT_CategoriaController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_Categoria
        public ActionResult Index()
        {
            var cAT_Categoria = db.CAT_Categoria.Include(c => c.CAT_TipoCategoria);
            return View(cAT_Categoria.ToList());
        }

        // GET: CAT_Categoria/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_Categoria cAT_Categoria = db.CAT_Categoria.Find(id);
            if (cAT_Categoria == null)
            {
                return HttpNotFound();
            }
            return View(cAT_Categoria);
        }

        // GET: CAT_Categoria/Create
        public ActionResult Create()
        {
            ViewBag.IdTipoCategoria = new SelectList(db.CAT_TipoCategoria, "Id", "NombreCategoria");
            return View();
        }

        // POST: CAT_Categoria/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,IdTipoCategoria")] CAT_Categoria cAT_Categoria)
        {
            if (ModelState.IsValid)
            {
                db.CAT_Categoria.Add(cAT_Categoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdTipoCategoria = new SelectList(db.CAT_TipoCategoria, "Id", "NombreCategoria", cAT_Categoria.IdTipoCategoria);
            return View(cAT_Categoria);
        }

        // GET: CAT_Categoria/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_Categoria cAT_Categoria = db.CAT_Categoria.Find(id);
            if (cAT_Categoria == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdTipoCategoria = new SelectList(db.CAT_TipoCategoria, "Id", "NombreCategoria", cAT_Categoria.IdTipoCategoria);
            return View(cAT_Categoria);
        }

        // POST: CAT_Categoria/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,IdTipoCategoria")] CAT_Categoria cAT_Categoria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_Categoria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdTipoCategoria = new SelectList(db.CAT_TipoCategoria, "Id", "NombreCategoria", cAT_Categoria.IdTipoCategoria);
            return View(cAT_Categoria);
        }

        // GET: CAT_Categoria/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_Categoria cAT_Categoria = db.CAT_Categoria.Find(id);
            if (cAT_Categoria == null)
            {
                return HttpNotFound();
            }
            return View(cAT_Categoria);
        }

        // POST: CAT_Categoria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_Categoria cAT_Categoria = db.CAT_Categoria.Find(id);
            db.CAT_Categoria.Remove(cAT_Categoria);
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
