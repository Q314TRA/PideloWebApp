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
    public class ZonaController : Controller
    {
        private pidelodbEntities db = new pidelodbEntities();

        // GET: Zona
        public ActionResult Index()
        {
            return View(db.tblZona.ToList());
        }

        // GET: Zona/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblZona tblZona = db.tblZona.Find(id);
            if (tblZona == null)
            {
                return HttpNotFound();
            }
            return View(tblZona);
        }

        // GET: Zona/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Zona/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idZona,nombre")] tblZona tblZona)
        {
            if (ModelState.IsValid)
            {
                db.tblZona.Add(tblZona);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblZona);
        }

        // GET: Zona/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblZona tblZona = db.tblZona.Find(id);
            if (tblZona == null)
            {
                return HttpNotFound();
            }
            return View(tblZona);
        }

        // POST: Zona/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idZona,nombre")] tblZona tblZona)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblZona).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblZona);
        }

        // GET: Zona/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblZona tblZona = db.tblZona.Find(id);
            if (tblZona == null)
            {
                return HttpNotFound();
            }
            return View(tblZona);
        }

        // POST: Zona/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblZona tblZona = db.tblZona.Find(id);
            db.tblZona.Remove(tblZona);
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
