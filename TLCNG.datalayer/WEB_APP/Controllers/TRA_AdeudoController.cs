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
    public class TRA_AdeudoController : Controller
    {
        private BDCatastroTulancingoEntities db = new BDCatastroTulancingoEntities();

        // GET: TRA_Adeudo
        public ActionResult Index()
        {
            return View(db.TRA_Adeudo.ToList());
        }

        // GET: TRA_Adeudo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_Adeudo tRA_Adeudo = db.TRA_Adeudo.Find(id);
            if (tRA_Adeudo == null)
            {
                return HttpNotFound();
            }
            return View(tRA_Adeudo);
        }

        // GET: TRA_Adeudo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TRA_Adeudo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nroTramite,clave,cuenta,clavecat,baseACalcular,baseGravable,impuesto,recargos,CargoExtra,condoImpuesto,condoRecargo,totalAdeudo,fechaIngreso,fechaEntrega,fechaGeneracionAdeudo,fechaInicioRecargos,LeyIngresos,DiasTranscurridos,ValorFiscal,ValorComercial,ValorReferido,Pagado,Descuento,MotivoDescuento,AñoLeyIngresos,Porcentaje")] TRA_Adeudo tRA_Adeudo)
        {
            if (ModelState.IsValid)
            {
                db.TRA_Adeudo.Add(tRA_Adeudo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tRA_Adeudo);
        }

        // GET: TRA_Adeudo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_Adeudo tRA_Adeudo = db.TRA_Adeudo.Find(id);
            if (tRA_Adeudo == null)
            {
                return HttpNotFound();
            }
            return View(tRA_Adeudo);
        }

        // POST: TRA_Adeudo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nroTramite,clave,cuenta,clavecat,baseACalcular,baseGravable,impuesto,recargos,CargoExtra,condoImpuesto,condoRecargo,totalAdeudo,fechaIngreso,fechaEntrega,fechaGeneracionAdeudo,fechaInicioRecargos,LeyIngresos,DiasTranscurridos,ValorFiscal,ValorComercial,ValorReferido,Pagado,Descuento,MotivoDescuento,AñoLeyIngresos,Porcentaje")] TRA_Adeudo tRA_Adeudo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tRA_Adeudo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tRA_Adeudo);
        }

        // GET: TRA_Adeudo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRA_Adeudo tRA_Adeudo = db.TRA_Adeudo.Find(id);
            if (tRA_Adeudo == null)
            {
                return HttpNotFound();
            }
            return View(tRA_Adeudo);
        }

        // POST: TRA_Adeudo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TRA_Adeudo tRA_Adeudo = db.TRA_Adeudo.Find(id);
            db.TRA_Adeudo.Remove(tRA_Adeudo);
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
