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
    public class CAT_tipoPerfilController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_tipoPerfil
        public ActionResult Index()
        {
            return View(db.CAT_tipoPerfil.ToList());
        }

        // GET: CAT_tipoPerfil/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_tipoPerfil cAT_tipoPerfil = db.CAT_tipoPerfil.Find(id);
            if (cAT_tipoPerfil == null)
            {
                return HttpNotFound();
            }
            return View(cAT_tipoPerfil);
        }

        // GET: CAT_tipoPerfil/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_tipoPerfil/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre")] CAT_tipoPerfil cAT_tipoPerfil)
        {
            if (ModelState.IsValid)
            {
                db.CAT_tipoPerfil.Add(cAT_tipoPerfil);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_tipoPerfil);
        }

        // GET: CAT_tipoPerfil/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_tipoPerfil cAT_tipoPerfil = db.CAT_tipoPerfil.Find(id);
            if (cAT_tipoPerfil == null)
            {
                return HttpNotFound();
            }
            return View(cAT_tipoPerfil);
        }

        // POST: CAT_tipoPerfil/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre")] CAT_tipoPerfil cAT_tipoPerfil)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_tipoPerfil).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_tipoPerfil);
        }

        // GET: CAT_tipoPerfil/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_tipoPerfil cAT_tipoPerfil = db.CAT_tipoPerfil.Find(id);
            if (cAT_tipoPerfil == null)
            {
                return HttpNotFound();
            }
            return View(cAT_tipoPerfil);
        }

        // POST: CAT_tipoPerfil/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_tipoPerfil cAT_tipoPerfil = db.CAT_tipoPerfil.Find(id);
            db.CAT_tipoPerfil.Remove(cAT_tipoPerfil);
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
