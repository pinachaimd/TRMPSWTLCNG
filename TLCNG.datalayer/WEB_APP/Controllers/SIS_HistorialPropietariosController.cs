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
    public class SIS_HistorialPropietariosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_HistorialPropietarios
        public ActionResult Index()
        {
            return View(db.SIS_HistorialPropietarios.ToList());
        }

        // GET: SIS_HistorialPropietarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialPropietarios sIS_HistorialPropietarios = db.SIS_HistorialPropietarios.Find(id);
            if (sIS_HistorialPropietarios == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialPropietarios);
        }

        // GET: SIS_HistorialPropietarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_HistorialPropietarios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,ApellidoPaterno,ApellidoMaterno,Sexo,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,TipoPropietario,NombreComercial,TelefonoFijo,DireccionDeNotificacion,IdColoniaDeNotificacion,CURP,RFC,TelefonoMovil,Municipio,Edificio,PorcentajePropiedad,PorcentajeUsufructo,PorcentajeNuda,IdPersonaVulnerable,PersonaFisica,FechaMovimiento")] SIS_HistorialPropietarios sIS_HistorialPropietarios)
        {
            if (ModelState.IsValid)
            {
                db.SIS_HistorialPropietarios.Add(sIS_HistorialPropietarios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_HistorialPropietarios);
        }

        // GET: SIS_HistorialPropietarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialPropietarios sIS_HistorialPropietarios = db.SIS_HistorialPropietarios.Find(id);
            if (sIS_HistorialPropietarios == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialPropietarios);
        }

        // POST: SIS_HistorialPropietarios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,ApellidoPaterno,ApellidoMaterno,Sexo,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,TipoPropietario,NombreComercial,TelefonoFijo,DireccionDeNotificacion,IdColoniaDeNotificacion,CURP,RFC,TelefonoMovil,Municipio,Edificio,PorcentajePropiedad,PorcentajeUsufructo,PorcentajeNuda,IdPersonaVulnerable,PersonaFisica,FechaMovimiento")] SIS_HistorialPropietarios sIS_HistorialPropietarios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_HistorialPropietarios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_HistorialPropietarios);
        }

        // GET: SIS_HistorialPropietarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_HistorialPropietarios sIS_HistorialPropietarios = db.SIS_HistorialPropietarios.Find(id);
            if (sIS_HistorialPropietarios == null)
            {
                return HttpNotFound();
            }
            return View(sIS_HistorialPropietarios);
        }

        // POST: SIS_HistorialPropietarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_HistorialPropietarios sIS_HistorialPropietarios = db.SIS_HistorialPropietarios.Find(id);
            db.SIS_HistorialPropietarios.Remove(sIS_HistorialPropietarios);
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
