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
    public class TRA_PropietariosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: TRA_Propietarios
        public ActionResult Index()
        {
            var tRA_Propietarios = db.TRA_Propietarios.Include(t => t.CAT_PersonaVulnerable);
            return View(tRA_Propietarios.ToList());
        }

        // GET: TRA_Propietarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_Propietarios tRA_Propietarios = db.TRA_Propietarios.Find(id);
            if (tRA_Propietarios == null)
            {
                return HttpNotFound();
            }
            return View(tRA_Propietarios);
        }

        // GET: TRA_Propietarios/Create
        public ActionResult Create()
        {
            ViewBag.IdPersonaVulnerable = new SelectList(db.CAT_PersonaVulnerable, "id", "clave");
            return View();
        }

        // POST: TRA_Propietarios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,ApellidoPaterno,ApellidoMaterno,Sexo,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,TipoPropietario,NombreComercial,TelefonoFijo,DireccionDeNotificacion,IdColoniaDeNotificacion,CURP,RFC,TelefonoMovil,Municipio,Edificio,PorcentajePropiedad,PorcentajeUsufructo,PorcentajeNuda,IdPersonaVulnerable,PersonaFisica,NroTramite")] TRA_Propietarios tRA_Propietarios)
        {
            if (ModelState.IsValid)
            {
                db.TRA_Propietarios.Add(tRA_Propietarios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdPersonaVulnerable = new SelectList(db.CAT_PersonaVulnerable, "id", "clave", tRA_Propietarios.IdPersonaVulnerable);
            return View(tRA_Propietarios);
        }

        // GET: TRA_Propietarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_Propietarios tRA_Propietarios = db.TRA_Propietarios.Find(id);
            if (tRA_Propietarios == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdPersonaVulnerable = new SelectList(db.CAT_PersonaVulnerable, "id", "clave", tRA_Propietarios.IdPersonaVulnerable);
            return View(tRA_Propietarios);
        }

        // POST: TRA_Propietarios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,ApellidoPaterno,ApellidoMaterno,Sexo,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,TipoPropietario,NombreComercial,TelefonoFijo,DireccionDeNotificacion,IdColoniaDeNotificacion,CURP,RFC,TelefonoMovil,Municipio,Edificio,PorcentajePropiedad,PorcentajeUsufructo,PorcentajeNuda,IdPersonaVulnerable,PersonaFisica,NroTramite")] TRA_Propietarios tRA_Propietarios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tRA_Propietarios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdPersonaVulnerable = new SelectList(db.CAT_PersonaVulnerable, "id", "clave", tRA_Propietarios.IdPersonaVulnerable);
            return View(tRA_Propietarios);
        }

        // GET: TRA_Propietarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_Propietarios tRA_Propietarios = db.TRA_Propietarios.Find(id);
            if (tRA_Propietarios == null)
            {
                return HttpNotFound();
            }
            return View(tRA_Propietarios);
        }

        // POST: TRA_Propietarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TRA_Propietarios tRA_Propietarios = db.TRA_Propietarios.Find(id);
            db.TRA_Propietarios.Remove(tRA_Propietarios);
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
