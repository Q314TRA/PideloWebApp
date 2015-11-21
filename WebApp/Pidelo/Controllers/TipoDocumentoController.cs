using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pidelo.Models;

namespace Pidelo.Controllers
{
    public class TipoDocumentoController : Controller
    {
        private pidelodbEntities db = new pidelodbEntities();

        // GET: TipoDocumento
        public ActionResult Index()
        {
            return View(db.tblTipoDocumento.ToList());
        }

        // GET: TipoDocumento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblTipoDocumento tblTipoDocumento = db.tblTipoDocumento.Find(id);
            if (tblTipoDocumento == null)
            {
                return HttpNotFound();
            }
            return View(tblTipoDocumento);
        }

        // GET: TipoDocumento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoDocumento/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idTipoDocumento,nombre")] tblTipoDocumento tblTipoDocumento)
        {
            if (ModelState.IsValid)
            {
                db.tblTipoDocumento.Add(tblTipoDocumento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblTipoDocumento);
        }

        // GET: TipoDocumento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblTipoDocumento tblTipoDocumento = db.tblTipoDocumento.Find(id);
            if (tblTipoDocumento == null)
            {
                return HttpNotFound();
            }
            return View(tblTipoDocumento);
        }

        // POST: TipoDocumento/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idTipoDocumento,nombre")] tblTipoDocumento tblTipoDocumento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblTipoDocumento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblTipoDocumento);
        }

        // GET: TipoDocumento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblTipoDocumento tblTipoDocumento = db.tblTipoDocumento.Find(id);
            if (tblTipoDocumento == null)
            {
                return HttpNotFound();
            }
            return View(tblTipoDocumento);
        }

        // POST: TipoDocumento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblTipoDocumento tblTipoDocumento = db.tblTipoDocumento.Find(id);
            db.tblTipoDocumento.Remove(tblTipoDocumento);
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
