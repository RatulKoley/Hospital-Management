using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hospital_Management.Models;

namespace Hospital_Management.Controllers
{
    public class DiagnosticsController : Controller
    {
        private HospitalManagementEntities db = new HospitalManagementEntities();

        // GET: Diagnostics
        public ActionResult Index()
        {
            return View(db.Diagnostics.ToList());
        }

        // GET: Diagnostics/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diagnostics diagnostics = db.Diagnostics.Find(id);
            if (diagnostics == null)
            {
                return HttpNotFound();
            }
            return View(diagnostics);
        }

        // GET: Diagnostics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Diagnostics/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] Diagnostics diagnostics)
        {
            if (ModelState.IsValid)
            {
                db.Diagnostics.Add(diagnostics);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(diagnostics);
        }

        // GET: Diagnostics/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diagnostics diagnostics = db.Diagnostics.Find(id);
            if (diagnostics == null)
            {
                return HttpNotFound();
            }
            return View(diagnostics);
        }

        // POST: Diagnostics/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] Diagnostics diagnostics)
        {
            if (ModelState.IsValid)
            {
                db.Entry(diagnostics).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(diagnostics);
        }

        // GET: Diagnostics/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diagnostics diagnostics = db.Diagnostics.Find(id);
            if (diagnostics == null)
            {
                return HttpNotFound();
            }
            return View(diagnostics);
        }

        // POST: Diagnostics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Diagnostics diagnostics = db.Diagnostics.Find(id);
            db.Diagnostics.Remove(diagnostics);
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
