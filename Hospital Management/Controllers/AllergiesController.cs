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
    public class AllergiesController : Controller
    {
        private HospitalManagementEntities db = new HospitalManagementEntities();

        // GET: Allergies
        public ActionResult Index()
        {
            return View(db.Allergy.ToList());
        }

        // GET: Allergies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Allergy allergy = db.Allergy.Find(id);
            if (allergy == null)
            {
                return HttpNotFound();
            }
            return View(allergy);
        }

        // GET: Allergies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Allergies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] Allergy allergy)
        {
            if (ModelState.IsValid)
            {
                db.Allergy.Add(allergy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(allergy);
        }

        // GET: Allergies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Allergy allergy = db.Allergy.Find(id);
            if (allergy == null)
            {
                return HttpNotFound();
            }
            return View(allergy);
        }

        // POST: Allergies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] Allergy allergy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(allergy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(allergy);
        }

        // GET: Allergies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Allergy allergy = db.Allergy.Find(id);
            if (allergy == null)
            {
                return HttpNotFound();
            }
            return View(allergy);
        }

        // POST: Allergies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Allergy allergy = db.Allergy.Find(id);
            db.Allergy.Remove(allergy);
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
