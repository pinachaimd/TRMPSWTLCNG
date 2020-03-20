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
    public class CAT_TRASLADOS_NotariasController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_TRASLADOS_Notarias
        public ActionResult Index()
        {
            return View(db.CAT_TRASLADOS_Notarias.ToList());
        }

        // GET: CAT_TRASLADOS_Notarias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TRASLADOS_Notarias cAT_TRASLADOS_Notarias = db.CAT_TRASLADOS_Notarias.Find(id);
            if (cAT_TRASLADOS_Notarias == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TRASLADOS_Notarias);
        }

        // GET: CAT_TRASLADOS_Notarias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_TRASLADOS_Notarias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Notaria,TitularNombre,TitularApellidoMaterno,TitularApellidoPaterno,Calle,NumExt,Colonia,Telefono,NumeroNotaria,Distrito")] CAT_TRASLADOS_Notarias cAT_TRASLADOS_Notarias)
        {
            if (ModelState.IsValid)
            {
                db.CAT_TRASLADOS_Notarias.Add(cAT_TRASLADOS_Notarias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_TRASLADOS_Notarias);
        }

        // GET: CAT_TRASLADOS_Notarias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TRASLADOS_Notarias cAT_TRASLADOS_Notarias = db.CAT_TRASLADOS_Notarias.Find(id);
            if (cAT_TRASLADOS_Notarias == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TRASLADOS_Notarias);
        }

        // POST: CAT_TRASLADOS_Notarias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Notaria,TitularNombre,TitularApellidoMaterno,TitularApellidoPaterno,Calle,NumExt,Colonia,Telefono,NumeroNotaria,Distrito")] CAT_TRASLADOS_Notarias cAT_TRASLADOS_Notarias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_TRASLADOS_Notarias).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_TRASLADOS_Notarias);
        }

        // GET: CAT_TRASLADOS_Notarias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TRASLADOS_Notarias cAT_TRASLADOS_Notarias = db.CAT_TRASLADOS_Notarias.Find(id);
            if (cAT_TRASLADOS_Notarias == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TRASLADOS_Notarias);
        }

        // POST: CAT_TRASLADOS_Notarias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_TRASLADOS_Notarias cAT_TRASLADOS_Notarias = db.CAT_TRASLADOS_Notarias.Find(id);
            db.CAT_TRASLADOS_Notarias.Remove(cAT_TRASLADOS_Notarias);
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
