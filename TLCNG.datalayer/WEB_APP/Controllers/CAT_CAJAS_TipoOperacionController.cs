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
    public class CAT_CAJAS_TipoOperacionController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: CAT_CAJAS_TipoOperacion
        public ActionResult Index()
        {
            return View(db.CAT_CAJAS_TipoOperacion.ToList());
        }

        // GET: CAT_CAJAS_TipoOperacion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_CAJAS_TipoOperacion cAT_CAJAS_TipoOperacion = db.CAT_CAJAS_TipoOperacion.Find(id);
            if (cAT_CAJAS_TipoOperacion == null)
            {
                return HttpNotFound();
            }
            return View(cAT_CAJAS_TipoOperacion);
        }

        // GET: CAT_CAJAS_TipoOperacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAT_CAJAS_TipoOperacion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NombreOperacion")] CAT_CAJAS_TipoOperacion cAT_CAJAS_TipoOperacion)
        {
            if (ModelState.IsValid)
            {
                db.CAT_CAJAS_TipoOperacion.Add(cAT_CAJAS_TipoOperacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAT_CAJAS_TipoOperacion);
        }

        // GET: CAT_CAJAS_TipoOperacion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_CAJAS_TipoOperacion cAT_CAJAS_TipoOperacion = db.CAT_CAJAS_TipoOperacion.Find(id);
            if (cAT_CAJAS_TipoOperacion == null)
            {
                return HttpNotFound();
            }
            return View(cAT_CAJAS_TipoOperacion);
        }

        // POST: CAT_CAJAS_TipoOperacion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NombreOperacion")] CAT_CAJAS_TipoOperacion cAT_CAJAS_TipoOperacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAT_CAJAS_TipoOperacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAT_CAJAS_TipoOperacion);
        }

        // GET: CAT_CAJAS_TipoOperacion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAT_CAJAS_TipoOperacion cAT_CAJAS_TipoOperacion = db.CAT_CAJAS_TipoOperacion.Find(id);
            if (cAT_CAJAS_TipoOperacion == null)
            {
                return HttpNotFound();
            }
            return View(cAT_CAJAS_TipoOperacion);
        }

        // POST: CAT_CAJAS_TipoOperacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CAT_CAJAS_TipoOperacion cAT_CAJAS_TipoOperacion = db.CAT_CAJAS_TipoOperacion.Find(id);
            db.CAT_CAJAS_TipoOperacion.Remove(cAT_CAJAS_TipoOperacion);
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
