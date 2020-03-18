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
    public class CAT_perfilController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_perfil
        public ActionResult Index()
        {
            var cAT_perfil = db.CAT_perfil.Include(c => c.CAT_sistema).Include(c => c.CAT_tipoPerfil);
            return View(cAT_perfil.ToList());
        }

        // GET: CAT_perfil/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_perfil cAT_perfil = db.CAT_perfil.Find(id);
            if (cAT_perfil == null)
            {
                return HttpNotFound();
            }
            return View(cAT_perfil);
        }

        // GET: CAT_perfil/Create
        public ActionResult Create()
        {
            ViewBag.idTipoPerfil = new SelectList(db.CAT_sistema, "id", "nombre");
            ViewBag.idTipoPerfil = new SelectList(db.CAT_tipoPerfil, "id", "nombre");
            return View();
        }

        // POST: CAT_perfil/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre,idSistema,idTipoPerfil")] CAT_perfil cAT_perfil)
        {
            if (ModelState.IsValid)
            {
                db.CAT_perfil.Add(cAT_perfil);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idTipoPerfil = new SelectList(db.CAT_sistema, "id", "nombre", cAT_perfil.idTipoPerfil);
            ViewBag.idTipoPerfil = new SelectList(db.CAT_tipoPerfil, "id", "nombre", cAT_perfil.idTipoPerfil);
            return View(cAT_perfil);
        }

        // GET: CAT_perfil/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_perfil cAT_perfil = db.CAT_perfil.Find(id);
            if (cAT_perfil == null)
            {
                return HttpNotFound();
            }
            ViewBag.idTipoPerfil = new SelectList(db.CAT_sistema, "id", "nombre", cAT_perfil.idTipoPerfil);
            ViewBag.idTipoPerfil = new SelectList(db.CAT_tipoPerfil, "id", "nombre", cAT_perfil.idTipoPerfil);
            return View(cAT_perfil);
        }

        // POST: CAT_perfil/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre,idSistema,idTipoPerfil")] CAT_perfil cAT_perfil)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_perfil).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idTipoPerfil = new SelectList(db.CAT_sistema, "id", "nombre", cAT_perfil.idTipoPerfil);
            ViewBag.idTipoPerfil = new SelectList(db.CAT_tipoPerfil, "id", "nombre", cAT_perfil.idTipoPerfil);
            return View(cAT_perfil);
        }

        // GET: CAT_perfil/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_perfil cAT_perfil = db.CAT_perfil.Find(id);
            if (cAT_perfil == null)
            {
                return HttpNotFound();
            }
            return View(cAT_perfil);
        }

        // POST: CAT_perfil/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_perfil cAT_perfil = db.CAT_perfil.Find(id);
            db.CAT_perfil.Remove(cAT_perfil);
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
