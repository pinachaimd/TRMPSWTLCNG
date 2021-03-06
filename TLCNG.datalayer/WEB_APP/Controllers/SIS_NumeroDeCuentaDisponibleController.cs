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
    public class SIS_NumeroDeCuentaDisponibleController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: SIS_NumeroDeCuentaDisponible
        public ActionResult Index()
        {
            return View(db.SIS_NumeroDeCuentaDisponible.ToList());
        }

        // GET: SIS_NumeroDeCuentaDisponible/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_NumeroDeCuentaDisponible sIS_NumeroDeCuentaDisponible = db.SIS_NumeroDeCuentaDisponible.Find(id);
            if (sIS_NumeroDeCuentaDisponible == null)
            {
                return HttpNotFound();
            }
            return View(sIS_NumeroDeCuentaDisponible);
        }

        // GET: SIS_NumeroDeCuentaDisponible/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SIS_NumeroDeCuentaDisponible/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "numero")] SIS_NumeroDeCuentaDisponible sIS_NumeroDeCuentaDisponible)
        {
            if (ModelState.IsValid)
            {
                db.SIS_NumeroDeCuentaDisponible.Add(sIS_NumeroDeCuentaDisponible);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sIS_NumeroDeCuentaDisponible);
        }

        // GET: SIS_NumeroDeCuentaDisponible/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_NumeroDeCuentaDisponible sIS_NumeroDeCuentaDisponible = db.SIS_NumeroDeCuentaDisponible.Find(id);
            if (sIS_NumeroDeCuentaDisponible == null)
            {
                return HttpNotFound();
            }
            return View(sIS_NumeroDeCuentaDisponible);
        }

        // POST: SIS_NumeroDeCuentaDisponible/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "numero")] SIS_NumeroDeCuentaDisponible sIS_NumeroDeCuentaDisponible)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sIS_NumeroDeCuentaDisponible).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sIS_NumeroDeCuentaDisponible);
        }

        // GET: SIS_NumeroDeCuentaDisponible/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SIS_NumeroDeCuentaDisponible sIS_NumeroDeCuentaDisponible = db.SIS_NumeroDeCuentaDisponible.Find(id);
            if (sIS_NumeroDeCuentaDisponible == null)
            {
                return HttpNotFound();
            }
            return View(sIS_NumeroDeCuentaDisponible);
        }

        // POST: SIS_NumeroDeCuentaDisponible/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SIS_NumeroDeCuentaDisponible sIS_NumeroDeCuentaDisponible = db.SIS_NumeroDeCuentaDisponible.Find(id);
            db.SIS_NumeroDeCuentaDisponible.Remove(sIS_NumeroDeCuentaDisponible);
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
