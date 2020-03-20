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
    public class MultasController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: Multas
        public ActionResult Index()
        {
            return View(db.Multas.ToList());
        }

        // GET: Multas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Multas multas = db.Multas.Find(id);
            if (multas == null)
            {
                return HttpNotFound();
            }
            return View(multas);
        }

        // GET: Multas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Multas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdMultas,Anio,SalarioMinVigentRegionC,SalarioMinVigentRegionB,MontoEquivDiasSalario")] Multas multas)
        {
            if (ModelState.IsValid)
            {
                db.Multas.Add(multas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(multas);
        }

        // GET: Multas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Multas multas = db.Multas.Find(id);
            if (multas == null)
            {
                return HttpNotFound();
            }
            return View(multas);
        }

        // POST: Multas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdMultas,Anio,SalarioMinVigentRegionC,SalarioMinVigentRegionB,MontoEquivDiasSalario")] Multas multas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(multas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(multas);
        }

        // GET: Multas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Multas multas = db.Multas.Find(id);
            if (multas == null)
            {
                return HttpNotFound();
            }
            return View(multas);
        }

        // POST: Multas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Multas multas = db.Multas.Find(id);
            db.Multas.Remove(multas);
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
