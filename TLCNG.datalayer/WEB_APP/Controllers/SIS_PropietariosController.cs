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
    public class SIS_PropietariosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_Propietarios
        public ActionResult Index()
        {
            return View(db.SIS_Propietarios.ToList());
        }

        // GET: SIS_Propietarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_Propietarios sIS_Propietarios = db.SIS_Propietarios.Find(id);
            if (sIS_Propietarios == null)
            {
                return HttpNotFound();
            }
            return View(sIS_Propietarios);
        }

        // GET: SIS_Propietarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_Propietarios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,ApellidoPaterno,ApellidoMaterno,Sexo,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,TipoPropietario,NombreComercial,TelefonoFijo,DireccionDeNotificacion,IdColoniaDeNotificacion,CURP,RFC,TelefonoMovil,Municipio,Edificio,PorcentajePropiedad,PorcentajeUsufructo,PorcentajeNuda,IdPersonaVulnerable,PersonaFisica")] SIS_Propietarios sIS_Propietarios)
        {
            if (ModelState.IsValid)
            {
                db.SIS_Propietarios.Add(sIS_Propietarios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_Propietarios);
        }

        // GET: SIS_Propietarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_Propietarios sIS_Propietarios = db.SIS_Propietarios.Find(id);
            if (sIS_Propietarios == null)
            {
                return HttpNotFound();
            }
            return View(sIS_Propietarios);
        }

        // POST: SIS_Propietarios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,ApellidoPaterno,ApellidoMaterno,Sexo,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,TipoPropietario,NombreComercial,TelefonoFijo,DireccionDeNotificacion,IdColoniaDeNotificacion,CURP,RFC,TelefonoMovil,Municipio,Edificio,PorcentajePropiedad,PorcentajeUsufructo,PorcentajeNuda,IdPersonaVulnerable,PersonaFisica")] SIS_Propietarios sIS_Propietarios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_Propietarios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_Propietarios);
        }

        // GET: SIS_Propietarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_Propietarios sIS_Propietarios = db.SIS_Propietarios.Find(id);
            if (sIS_Propietarios == null)
            {
                return HttpNotFound();
            }
            return View(sIS_Propietarios);
        }

        // POST: SIS_Propietarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_Propietarios sIS_Propietarios = db.SIS_Propietarios.Find(id);
            db.SIS_Propietarios.Remove(sIS_Propietarios);
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
