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
    public class SIS_HistorialUsuarioController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_HistorialUsuario
        public ActionResult Index()
        {
            return View(db.SIS_HistorialUsuario.ToList());
        }

        // GET: SIS_HistorialUsuario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialUsuario sIS_HistorialUsuario = db.SIS_HistorialUsuario.Find(id);
            if (sIS_HistorialUsuario == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialUsuario);
        }

        // GET: SIS_HistorialUsuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_HistorialUsuario/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre,aPaterno,aMaterno,nombreUsuario,idPuesto,idCoordinacion,idPerfilAccesoPredial,idPerfilAccesoGestion,idPerfilAccesoWeb,idPerfilAccesoCaja,fechaActualizacion,permisoUsuarios,permisoPerfiles,idPerfil,fechaDeBaja,identificador,UsuarioElimina")] SIS_HistorialUsuario sIS_HistorialUsuario)
        {
            if (ModelState.IsValid)
            {
                db.SIS_HistorialUsuario.Add(sIS_HistorialUsuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_HistorialUsuario);
        }

        // GET: SIS_HistorialUsuario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialUsuario sIS_HistorialUsuario = db.SIS_HistorialUsuario.Find(id);
            if (sIS_HistorialUsuario == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialUsuario);
        }

        // POST: SIS_HistorialUsuario/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre,aPaterno,aMaterno,nombreUsuario,idPuesto,idCoordinacion,idPerfilAccesoPredial,idPerfilAccesoGestion,idPerfilAccesoWeb,idPerfilAccesoCaja,fechaActualizacion,permisoUsuarios,permisoPerfiles,idPerfil,fechaDeBaja,identificador,UsuarioElimina")] SIS_HistorialUsuario sIS_HistorialUsuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_HistorialUsuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_HistorialUsuario);
        }

        // GET: SIS_HistorialUsuario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialUsuario sIS_HistorialUsuario = db.SIS_HistorialUsuario.Find(id);
            if (sIS_HistorialUsuario == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialUsuario);
        }

        // POST: SIS_HistorialUsuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_HistorialUsuario sIS_HistorialUsuario = db.SIS_HistorialUsuario.Find(id);
            db.SIS_HistorialUsuario.Remove(sIS_HistorialUsuario);
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
