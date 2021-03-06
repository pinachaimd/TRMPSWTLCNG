﻿using System;
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
    public class CAT_TRASLADOS_NombreFestividadesController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_TRASLADOS_NombreFestividades
        public ActionResult Index()
        {
            return View(db.CAT_TRASLADOS_NombreFestividades.ToList());
        }

        // GET: CAT_TRASLADOS_NombreFestividades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TRASLADOS_NombreFestividades cAT_TRASLADOS_NombreFestividades = db.CAT_TRASLADOS_NombreFestividades.Find(id);
            if (cAT_TRASLADOS_NombreFestividades == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TRASLADOS_NombreFestividades);
        }

        // GET: CAT_TRASLADOS_NombreFestividades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_TRASLADOS_NombreFestividades/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Festividad")] CAT_TRASLADOS_NombreFestividades cAT_TRASLADOS_NombreFestividades)
        {
            if (ModelState.IsValid)
            {
                db.CAT_TRASLADOS_NombreFestividades.Add(cAT_TRASLADOS_NombreFestividades);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_TRASLADOS_NombreFestividades);
        }

        // GET: CAT_TRASLADOS_NombreFestividades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TRASLADOS_NombreFestividades cAT_TRASLADOS_NombreFestividades = db.CAT_TRASLADOS_NombreFestividades.Find(id);
            if (cAT_TRASLADOS_NombreFestividades == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TRASLADOS_NombreFestividades);
        }

        // POST: CAT_TRASLADOS_NombreFestividades/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Festividad")] CAT_TRASLADOS_NombreFestividades cAT_TRASLADOS_NombreFestividades)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_TRASLADOS_NombreFestividades).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_TRASLADOS_NombreFestividades);
        }

        // GET: CAT_TRASLADOS_NombreFestividades/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_TRASLADOS_NombreFestividades cAT_TRASLADOS_NombreFestividades = db.CAT_TRASLADOS_NombreFestividades.Find(id);
            if (cAT_TRASLADOS_NombreFestividades == null)
            {
                return HttpNotFound();
            }
            return View(cAT_TRASLADOS_NombreFestividades);
        }

        // POST: CAT_TRASLADOS_NombreFestividades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_TRASLADOS_NombreFestividades cAT_TRASLADOS_NombreFestividades = db.CAT_TRASLADOS_NombreFestividades.Find(id);
            db.CAT_TRASLADOS_NombreFestividades.Remove(cAT_TRASLADOS_NombreFestividades);
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
