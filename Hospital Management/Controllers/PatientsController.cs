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
    public class PatientsController : Controller
    {
        private HospitalManagementEntities db = new HospitalManagementEntities();

        // GET: Patients
        public ActionResult Index()
        {
            var patient = db.Patient.Include(p => p.District).Include(p => p.Place1);
            return View(patient.ToList());
        }

        // GET: Patients/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = db.Patient.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // GET: Patients/Create
        public ActionResult Create()
        {
            ViewBag.District_Name = new SelectList(db.District, "ID", "District1");
            ViewBag.Place = new SelectList(db.Place, "ID", "Place1");
            return View();
        }

        // POST: Patients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CR_Number,Aadhar_No,First_Name,Middle_Name,Last_Name,Relative,Relative_Name,Age_Year,Age_Month,Blood_Group,Marital_Status,Mobile,Email,Picture,Gender,Address,District_Name,Place,PIN,Registration_Date,Admin")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                db.Patient.Add(patient);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.District_Name = new SelectList(db.District, "ID", "District1", patient.District_Name);
            ViewBag.Place = new SelectList(db.Place, "ID", "Place1", patient.Place);
            return View(patient);
        }

        // GET: Patients/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = db.Patient.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            ViewBag.District_Name = new SelectList(db.District, "ID", "District1", patient.District_Name);
            ViewBag.Place = new SelectList(db.Place, "ID", "Place1", patient.Place);
            return View(patient);
        }

        // POST: Patients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CR_Number,Aadhar_No,First_Name,Middle_Name,Last_Name,Relative,Relative_Name,Age_Year,Age_Month,Blood_Group,Marital_Status,Mobile,Email,Picture,Gender,Address,District_Name,Place,PIN,Registration_Date,Admin")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patient).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.District_Name = new SelectList(db.District, "ID", "District1", patient.District_Name);
            ViewBag.Place = new SelectList(db.Place, "ID", "Place1", patient.Place);
            return View(patient);
        }

        // GET: Patients/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = db.Patient.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // POST: Patients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Patient patient = db.Patient.Find(id);
            db.Patient.Remove(patient);
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
