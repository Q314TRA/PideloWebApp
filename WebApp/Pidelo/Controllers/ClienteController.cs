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
    public class ClienteController : Controller
    {
        private pidelodbEntities db = new pidelodbEntities();

        // GET: Cliente
        public ActionResult Index()
        {
            var tblCliente = db.tblCliente.Include(t => t.tblTipoDocumento);
            return View(tblCliente.ToList());
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblCliente tblCliente = db.tblCliente.Find(id);
            if (tblCliente == null)
            {
                return HttpNotFound();
            }
            return View(tblCliente);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            ViewBag.idTipoDocumento = new SelectList(db.tblTipoDocumento, "idTipoDocumento", "nombre");
            return View();
        }

        // POST: Cliente/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCliente,razonSocial,nombreComercial,idTipoDocumento,documento")] tblCliente tblCliente)
        {
            if (ModelState.IsValid)
            {
                db.tblCliente.Add(tblCliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idTipoDocumento = new SelectList(db.tblTipoDocumento, "idTipoDocumento", "nombre", tblCliente.idTipoDocumento);
            return View(tblCliente);
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblCliente tblCliente = db.tblCliente.Find(id);
            if (tblCliente == null)
            {
                return HttpNotFound();
            }
            ViewBag.idTipoDocumento = new SelectList(db.tblTipoDocumento, "idTipoDocumento", "nombre", tblCliente.idTipoDocumento);
            return View(tblCliente);
        }

        // POST: Cliente/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCliente,razonSocial,nombreComercial,idTipoDocumento,documento")] tblCliente tblCliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblCliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idTipoDocumento = new SelectList(db.tblTipoDocumento, "idTipoDocumento", "nombre", tblCliente.idTipoDocumento);
            return View(tblCliente);
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblCliente tblCliente = db.tblCliente.Find(id);
            if (tblCliente == null)
            {
                return HttpNotFound();
            }
            return View(tblCliente);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblCliente tblCliente = db.tblCliente.Find(id);
            db.tblCliente.Remove(tblCliente);
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
