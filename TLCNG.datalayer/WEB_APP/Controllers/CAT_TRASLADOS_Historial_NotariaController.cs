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
    public class CAT_TRASLADOS_Historial_NotariaController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_TRASLADOS_Historial_Notaria
        public ActionResult Index()
        {
            return View(db.CAT_TRASLADOS_Historial_Notaria.ToList());
        }

        // GET: CAT_TRASLADOS_Historial_Notaria/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TRASLADOS_Historial_Notaria cAT_TRASLADOS_Historial_Notaria = db.CAT_TRASLADOS_Historial_Notaria.Find(id);
            if (cAT_TRASLADOS_Historial_Notaria == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TRASLADOS_Historial_Notaria);
        }

        // GET: CAT_TRASLADOS_Historial_Notaria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_TRASLADOS_Historial_Notaria/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,TipoModificacion,Notaria,TitularNombre,TitularApellidoMaterno,TitularApellidoPaterno,Calle,NumExt,Colonia,Telefono,FechaModificacion,idAnterior")] CAT_TRASLADOS_Historial_Notaria cAT_TRASLADOS_Historial_Notaria)
        {
            if (ModelState.IsValid)
            {
                db.CAT_TRASLADOS_Historial_Notaria.Add(cAT_TRASLADOS_Historial_Notaria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_TRASLADOS_Historial_Notaria);
        }

        // GET: CAT_TRASLADOS_Historial_Notaria/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TRASLADOS_Historial_Notaria cAT_TRASLADOS_Historial_Notaria = db.CAT_TRASLADOS_Historial_Notaria.Find(id);
            if (cAT_TRASLADOS_Historial_Notaria == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TRASLADOS_Historial_Notaria);
        }

        // POST: CAT_TRASLADOS_Historial_Notaria/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,TipoModificacion,Notaria,TitularNombre,TitularApellidoMaterno,TitularApellidoPaterno,Calle,NumExt,Colonia,Telefono,FechaModificacion,idAnterior")] CAT_TRASLADOS_Historial_Notaria cAT_TRASLADOS_Historial_Notaria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_TRASLADOS_Historial_Notaria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_TRASLADOS_Historial_Notaria);
        }

        // GET: CAT_TRASLADOS_Historial_Notaria/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TRASLADOS_Historial_Notaria cAT_TRASLADOS_Historial_Notaria = db.CAT_TRASLADOS_Historial_Notaria.Find(id);
            if (cAT_TRASLADOS_Historial_Notaria == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TRASLADOS_Historial_Notaria);
        }

        // POST: CAT_TRASLADOS_Historial_Notaria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_TRASLADOS_Historial_Notaria cAT_TRASLADOS_Historial_Notaria = db.CAT_TRASLADOS_Historial_Notaria.Find(id);
            db.CAT_TRASLADOS_Historial_Notaria.Remove(cAT_TRASLADOS_Historial_Notaria);
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
