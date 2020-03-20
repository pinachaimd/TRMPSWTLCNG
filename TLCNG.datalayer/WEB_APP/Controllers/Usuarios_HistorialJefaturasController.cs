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
    public class Usuarios_HistorialJefaturasController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: Usuarios_HistorialJefaturas
        public ActionResult Index()
        {
            return View(db.Usuarios_HistorialJefaturas.ToList());
        }

        // GET: Usuarios_HistorialJefaturas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuarios_HistorialJefaturas usuarios_HistorialJefaturas = db.Usuarios_HistorialJefaturas.Find(id);
            if (usuarios_HistorialJefaturas == null)
            {
                return HttpNotFound();
            }
            return View(usuarios_HistorialJefaturas);
        }

        // GET: Usuarios_HistorialJefaturas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuarios_HistorialJefaturas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,idUsuario,fecha,hora,departamentoModificado")] Usuarios_HistorialJefaturas usuarios_HistorialJefaturas)
        {
            if (ModelState.IsValid)
            {
                db.Usuarios_HistorialJefaturas.Add(usuarios_HistorialJefaturas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usuarios_HistorialJefaturas);
        }

        // GET: Usuarios_HistorialJefaturas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuarios_HistorialJefaturas usuarios_HistorialJefaturas = db.Usuarios_HistorialJefaturas.Find(id);
            if (usuarios_HistorialJefaturas == null)
            {
                return HttpNotFound();
            }
            return View(usuarios_HistorialJefaturas);
        }

        // POST: Usuarios_HistorialJefaturas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idUsuario,fecha,hora,departamentoModificado")] Usuarios_HistorialJefaturas usuarios_HistorialJefaturas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuarios_HistorialJefaturas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuarios_HistorialJefaturas);
        }

        // GET: Usuarios_HistorialJefaturas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuarios_HistorialJefaturas usuarios_HistorialJefaturas = db.Usuarios_HistorialJefaturas.Find(id);
            if (usuarios_HistorialJefaturas == null)
            {
                return HttpNotFound();
            }
            return View(usuarios_HistorialJefaturas);
        }

        // POST: Usuarios_HistorialJefaturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Usuarios_HistorialJefaturas usuarios_HistorialJefaturas = db.Usuarios_HistorialJefaturas.Find(id);
            db.Usuarios_HistorialJefaturas.Remove(usuarios_HistorialJefaturas);
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
