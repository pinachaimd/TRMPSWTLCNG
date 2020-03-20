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
    public class sp_helpdiagrams_ResultController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: sp_helpdiagrams_Result
        public ActionResult Index()
        {
            return View(db.sp_helpdiagrams_Result.ToList());
        }

        // GET: sp_helpdiagrams_Result/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sp_helpdiagrams_Result sp_helpdiagrams_Result = db.sp_helpdiagrams_Result.Find(id);
            if (sp_helpdiagrams_Result == null)
            {
                return HttpNotFound();
            }
            return View(sp_helpdiagrams_Result);
        }

        // GET: sp_helpdiagrams_Result/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: sp_helpdiagrams_Result/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Database,Name,Owner,OwnerID")] sp_helpdiagrams_Result sp_helpdiagrams_Result)
        {
            if (ModelState.IsValid)
            {
                db.sp_helpdiagrams_Result.Add(sp_helpdiagrams_Result);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sp_helpdiagrams_Result);
        }

        // GET: sp_helpdiagrams_Result/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sp_helpdiagrams_Result sp_helpdiagrams_Result = db.sp_helpdiagrams_Result.Find(id);
            if (sp_helpdiagrams_Result == null)
            {
                return HttpNotFound();
            }
            return View(sp_helpdiagrams_Result);
        }

        // POST: sp_helpdiagrams_Result/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Database,Name,Owner,OwnerID")] sp_helpdiagrams_Result sp_helpdiagrams_Result)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sp_helpdiagrams_Result).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sp_helpdiagrams_Result);
        }

        // GET: sp_helpdiagrams_Result/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sp_helpdiagrams_Result sp_helpdiagrams_Result = db.sp_helpdiagrams_Result.Find(id);
            if (sp_helpdiagrams_Result == null)
            {
                return HttpNotFound();
            }
            return View(sp_helpdiagrams_Result);
        }

        // POST: sp_helpdiagrams_Result/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            sp_helpdiagrams_Result sp_helpdiagrams_Result = db.sp_helpdiagrams_Result.Find(id);
            db.sp_helpdiagrams_Result.Remove(sp_helpdiagrams_Result);
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
