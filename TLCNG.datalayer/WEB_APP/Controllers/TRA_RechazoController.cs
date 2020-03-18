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
    public class TRA_RechazoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: TRA_Rechazo
        public ActionResult Index()
        {
            return View(db.TRA_Rechazo.ToList());
        }

        // GET: TRA_Rechazo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_Rechazo tRA_Rechazo = db.TRA_Rechazo.Find(id);
            if (tRA_Rechazo == null)
            {
                return HttpNotFound();
            }
            return View(tRA_Rechazo);
        }

        // GET: TRA_Rechazo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TRA_Rechazo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,MotivoRechazo,idSolicitante,Fecharechazo,NoTramite,StatusAnterior,CLaveCatastral,IdProcesoAnterior,nombreSolicitante,AreaRechazo,EstadoActual,idTareaAnterior,IdUsuarioRechazo")] TRA_Rechazo tRA_Rechazo)
        {
            if (ModelState.IsValid)
            {
                db.TRA_Rechazo.Add(tRA_Rechazo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tRA_Rechazo);
        }

        // GET: TRA_Rechazo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_Rechazo tRA_Rechazo = db.TRA_Rechazo.Find(id);
            if (tRA_Rechazo == null)
            {
                return HttpNotFound();
            }
            return View(tRA_Rechazo);
        }

        // POST: TRA_Rechazo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,MotivoRechazo,idSolicitante,Fecharechazo,NoTramite,StatusAnterior,CLaveCatastral,IdProcesoAnterior,nombreSolicitante,AreaRechazo,EstadoActual,idTareaAnterior,IdUsuarioRechazo")] TRA_Rechazo tRA_Rechazo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tRA_Rechazo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tRA_Rechazo);
        }

        // GET: TRA_Rechazo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_Rechazo tRA_Rechazo = db.TRA_Rechazo.Find(id);
            if (tRA_Rechazo == null)
            {
                return HttpNotFound();
            }
            return View(tRA_Rechazo);
        }

        // POST: TRA_Rechazo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TRA_Rechazo tRA_Rechazo = db.TRA_Rechazo.Find(id);
            db.TRA_Rechazo.Remove(tRA_Rechazo);
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
