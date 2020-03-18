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
    public class CAT_SexoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_Sexo
        public ActionResult Index()
        {
            return View(db.CAT_Sexo.ToList());
        }

        // GET: CAT_Sexo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_Sexo cAT_Sexo = db.CAT_Sexo.Find(id);
            if (cAT_Sexo == null)
            {
                return HttpNotFound();
            }
            return View(cAT_Sexo);
        }

        // GET: CAT_Sexo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_Sexo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Sexo")] CAT_Sexo cAT_Sexo)
        {
            if (ModelState.IsValid)
            {
                db.CAT_Sexo.Add(cAT_Sexo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_Sexo);
        }

        // GET: CAT_Sexo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_Sexo cAT_Sexo = db.CAT_Sexo.Find(id);
            if (cAT_Sexo == null)
            {
                return HttpNotFound();
            }
            return View(cAT_Sexo);
        }

        // POST: CAT_Sexo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Sexo")] CAT_Sexo cAT_Sexo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_Sexo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_Sexo);
        }

        // GET: CAT_Sexo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_Sexo cAT_Sexo = db.CAT_Sexo.Find(id);
            if (cAT_Sexo == null)
            {
                return HttpNotFound();
            }
            return View(cAT_Sexo);
        }

        // POST: CAT_Sexo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_Sexo cAT_Sexo = db.CAT_Sexo.Find(id);
            db.CAT_Sexo.Remove(cAT_Sexo);
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
