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
    public class CANCELADO_SIS_PropietariosController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CANCELADO_SIS_Propietarios
        public ActionResult Index()
        {
            return View(db.CANCELADO_SIS_Propietarios.ToList());
        }

        // GET: CANCELADO_SIS_Propietarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_Propietarios cANCELADO_SIS_Propietarios = db.CANCELADO_SIS_Propietarios.Find(id);
            if (cANCELADO_SIS_Propietarios == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_Propietarios);
        }

        // GET: CANCELADO_SIS_Propietarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CANCELADO_SIS_Propietarios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,ApellidoPaterno,ApellidoMaterno,Sexo,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,TipoPropietario,NombreComercial,TelefonoFijo,DireccionDeNotificacion,IdColoniaDeNotificacion,CURP,RFC,TelefonoMovil,Municipio,Edificio,PorcentajePropiedad,PorcentajeUsufructo,PorcentajeNuda,IdPersonaVulnerable,PersonaFisica")] CANCELADO_SIS_Propietarios cANCELADO_SIS_Propietarios)
        {
            if (ModelState.IsValid)
            {
                db.CANCELADO_SIS_Propietarios.Add(cANCELADO_SIS_Propietarios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cANCELADO_SIS_Propietarios);
        }

        // GET: CANCELADO_SIS_Propietarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_Propietarios cANCELADO_SIS_Propietarios = db.CANCELADO_SIS_Propietarios.Find(id);
            if (cANCELADO_SIS_Propietarios == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_Propietarios);
        }

        // POST: CANCELADO_SIS_Propietarios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,ApellidoPaterno,ApellidoMaterno,Sexo,Clave,NumeroDeCuenta,Region,Manzana,Predio,Condominio,TipoPropietario,NombreComercial,TelefonoFijo,DireccionDeNotificacion,IdColoniaDeNotificacion,CURP,RFC,TelefonoMovil,Municipio,Edificio,PorcentajePropiedad,PorcentajeUsufructo,PorcentajeNuda,IdPersonaVulnerable,PersonaFisica")] CANCELADO_SIS_Propietarios cANCELADO_SIS_Propietarios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cANCELADO_SIS_Propietarios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cANCELADO_SIS_Propietarios);
        }

        // GET: CANCELADO_SIS_Propietarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CANCELADO_SIS_Propietarios cANCELADO_SIS_Propietarios = db.CANCELADO_SIS_Propietarios.Find(id);
            if (cANCELADO_SIS_Propietarios == null)
            {
                return HttpNotFound();
            }
            return View(cANCELADO_SIS_Propietarios);
        }

        // POST: CANCELADO_SIS_Propietarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CANCELADO_SIS_Propietarios cANCELADO_SIS_Propietarios = db.CANCELADO_SIS_Propietarios.Find(id);
            db.CANCELADO_SIS_Propietarios.Remove(cANCELADO_SIS_Propietarios);
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
