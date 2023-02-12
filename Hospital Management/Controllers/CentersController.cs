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
    public class CentersController : Controller
    {
        private HospitalManagementEntities db = new HospitalManagementEntities();

        // GET: Centers
        public ActionResult Index()
        {
            var center = db.Center.Include(c => c.Place);
            return View(center.ToList());
        }

        // GET: Centers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Center center = db.Center.Find(id);
            if (center == null)
            {
                return HttpNotFound();
            }
            return View(center);
        }

        // GET: Centers/Create
        public ActionResult Create()
        {
            ViewBag.Place_ID = new SelectList(db.Place, "ID", "Place1");
            return View();
        }

        // POST: Centers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Center1,Place_ID")] Center center)
        {
            if (ModelState.IsValid)
            {
                db.Center.Add(center);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Place_ID = new SelectList(db.Place, "ID", "Place1", center.Place_ID);
            return View(center);
        }

        // GET: Centers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Center center = db.Center.Find(id);
            if (center == null)
            {
                return HttpNotFound();
            }
            ViewBag.Place_ID = new SelectList(db.Place, "ID", "Place1", center.Place_ID);
            return View(center);
        }

        // POST: Centers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Center1,Place_ID")] Center center)
        {
            if (ModelState.IsValid)
            {
                db.Entry(center).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Place_ID = new SelectList(db.Place, "ID", "Place1", center.Place_ID);
            return View(center);
        }

        // GET: Centers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Center center = db.Center.Find(id);
            if (center == null)
            {
                return HttpNotFound();
            }
            return View(center);
        }

        // POST: Centers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Center center = db.Center.Find(id);
            db.Center.Remove(center);
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
