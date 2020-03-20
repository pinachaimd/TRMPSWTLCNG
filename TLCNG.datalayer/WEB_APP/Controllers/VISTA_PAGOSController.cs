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
    public class VISTA_PAGOSController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: VISTA_PAGOS
        public ActionResult Index()
        {
            return View(db.VISTA_PAGOS.ToList());
        }

        // GET: VISTA_PAGOS/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VISTA_PAGOS vISTA_PAGOS = db.VISTA_PAGOS.Find(id);
            if (vISTA_PAGOS == null)
            {
                return HttpNotFound();
            }
            return View(vISTA_PAGOS);
        }

        // GET: VISTA_PAGOS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VISTA_PAGOS/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Clave,NumeroDeCuenta,Nombre,ApellidoPaterno,ApellidoMaterno,BaseGravable,AreaTerreno,NombreCalle,NombreDeVialidad,Colonia,NombreTipoColonia,ClaveCatastral,NumeroExterior,NumeroInterior,Lote,Manzana,Zona,Parcela,IdColoniaDePredio,IdManzana,Cantidad,FechaDePago,AÑO")] VISTA_PAGOS vISTA_PAGOS)
        {
            if (ModelState.IsValid)
            {
                db.VISTA_PAGOS.Add(vISTA_PAGOS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vISTA_PAGOS);
        }

        // GET: VISTA_PAGOS/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VISTA_PAGOS vISTA_PAGOS = db.VISTA_PAGOS.Find(id);
            if (vISTA_PAGOS == null)
            {
                return HttpNotFound();
            }
            return View(vISTA_PAGOS);
        }

        // POST: VISTA_PAGOS/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Clave,NumeroDeCuenta,Nombre,ApellidoPaterno,ApellidoMaterno,BaseGravable,AreaTerreno,NombreCalle,NombreDeVialidad,Colonia,NombreTipoColonia,ClaveCatastral,NumeroExterior,NumeroInterior,Lote,Manzana,Zona,Parcela,IdColoniaDePredio,IdManzana,Cantidad,FechaDePago,AÑO")] VISTA_PAGOS vISTA_PAGOS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vISTA_PAGOS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vISTA_PAGOS);
        }

        // GET: VISTA_PAGOS/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VISTA_PAGOS vISTA_PAGOS = db.VISTA_PAGOS.Find(id);
            if (vISTA_PAGOS == null)
            {
                return HttpNotFound();
            }
            return View(vISTA_PAGOS);
        }

        // POST: VISTA_PAGOS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            VISTA_PAGOS vISTA_PAGOS = db.VISTA_PAGOS.Find(id);
            db.VISTA_PAGOS.Remove(vISTA_PAGOS);
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
