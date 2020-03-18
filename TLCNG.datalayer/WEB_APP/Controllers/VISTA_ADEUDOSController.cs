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
    public class VISTA_ADEUDOSController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: VISTA_ADEUDOS
        public ActionResult Index()
        {
            return View(db.VISTA_ADEUDOS.ToList());
        }

        // GET: VISTA_ADEUDOS/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VISTA_ADEUDOS vISTA_ADEUDOS = db.VISTA_ADEUDOS.Find(id);
            if (vISTA_ADEUDOS == null)
            {
                return HttpNotFound();
            }
            return View(vISTA_ADEUDOS);
        }

        // GET: VISTA_ADEUDOS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VISTA_ADEUDOS/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Clave,NumeroDeCuenta,Nombre,ApellidoPaterno,ApellidoMaterno,BaseGravable,AreaTerreno,NombreCalle,NombreDeVialidad,Colonia,NombreTipoColonia,ClaveCatastral,NumeroExterior,NumeroInterior,Lote,Manzana,Zona,Parcela,año,Adeudo,Recargo,CondonacionGeneral,Multa,IdColoniaDePredio,IdManzana")] VISTA_ADEUDOS vISTA_ADEUDOS)
        {
            if (ModelState.IsValid)
            {
                db.VISTA_ADEUDOS.Add(vISTA_ADEUDOS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vISTA_ADEUDOS);
        }

        // GET: VISTA_ADEUDOS/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VISTA_ADEUDOS vISTA_ADEUDOS = db.VISTA_ADEUDOS.Find(id);
            if (vISTA_ADEUDOS == null)
            {
                return HttpNotFound();
            }
            return View(vISTA_ADEUDOS);
        }

        // POST: VISTA_ADEUDOS/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Clave,NumeroDeCuenta,Nombre,ApellidoPaterno,ApellidoMaterno,BaseGravable,AreaTerreno,NombreCalle,NombreDeVialidad,Colonia,NombreTipoColonia,ClaveCatastral,NumeroExterior,NumeroInterior,Lote,Manzana,Zona,Parcela,año,Adeudo,Recargo,CondonacionGeneral,Multa,IdColoniaDePredio,IdManzana")] VISTA_ADEUDOS vISTA_ADEUDOS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vISTA_ADEUDOS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vISTA_ADEUDOS);
        }

        // GET: VISTA_ADEUDOS/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VISTA_ADEUDOS vISTA_ADEUDOS = db.VISTA_ADEUDOS.Find(id);
            if (vISTA_ADEUDOS == null)
            {
                return HttpNotFound();
            }
            return View(vISTA_ADEUDOS);
        }

        // POST: VISTA_ADEUDOS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            VISTA_ADEUDOS vISTA_ADEUDOS = db.VISTA_ADEUDOS.Find(id);
            db.VISTA_ADEUDOS.Remove(vISTA_ADEUDOS);
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
