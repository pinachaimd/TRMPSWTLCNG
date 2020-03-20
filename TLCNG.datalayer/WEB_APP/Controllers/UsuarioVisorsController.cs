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
    public class UsuarioVisorsController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: UsuarioVisors
        public ActionResult Index()
        {
            return View(db.UsuarioVisor.ToList());
        }

        // GET: UsuarioVisors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsuarioVisor usuarioVisor = db.UsuarioVisor.Find(id);
            if (usuarioVisor == null)
            {
                return HttpNotFound();
            }
            return View(usuarioVisor);
        }

        // GET: UsuarioVisors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioVisors/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre,aPaterno,aMaterno,nombreUsuario,contraseña,sesionIniciada,idSesion,fechaIngreso,UsuarioQueDioAlta,Notaria")] UsuarioVisor usuarioVisor)
        {
            if (ModelState.IsValid)
            {
                db.UsuarioVisor.Add(usuarioVisor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usuarioVisor);
        }

        // GET: UsuarioVisors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsuarioVisor usuarioVisor = db.UsuarioVisor.Find(id);
            if (usuarioVisor == null)
            {
                return HttpNotFound();
            }
            return View(usuarioVisor);
        }

        // POST: UsuarioVisors/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre,aPaterno,aMaterno,nombreUsuario,contraseña,sesionIniciada,idSesion,fechaIngreso,UsuarioQueDioAlta,Notaria")] UsuarioVisor usuarioVisor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuarioVisor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuarioVisor);
        }

        // GET: UsuarioVisors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsuarioVisor usuarioVisor = db.UsuarioVisor.Find(id);
            if (usuarioVisor == null)
            {
                return HttpNotFound();
            }
            return View(usuarioVisor);
        }

        // POST: UsuarioVisors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UsuarioVisor usuarioVisor = db.UsuarioVisor.Find(id);
            db.UsuarioVisor.Remove(usuarioVisor);
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
