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
    public class Patient_CaseController : Controller
    {
        private HospitalManagementEntities db = new HospitalManagementEntities();

        // GET: Patient_Case
        public ActionResult Index()
        {
            var patient_Case = db.Patient_Case.Include(p => p.Allergy).Include(p => p.Center).Include(p => p.Diagnostics).Include(p => p.District).Include(p => p.Doctor).Include(p => p.Patient).Include(p => p.Place1).Include(p => p.Problems);
            return View(patient_Case.ToList());
        }

        // GET: Patient_Case/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient_Case patient_Case = db.Patient_Case.Find(id);
            if (patient_Case == null)
            {
                return HttpNotFound();
            }
            return View(patient_Case);
        }

        // GET: Patient_Case/Create
        public ActionResult Create()
        {
            ViewBag.Allergy_Name = new SelectList(db.Allergy, "ID", "Name");
            ViewBag.Center_Name = new SelectList(db.Center, "ID", "Center1");
            ViewBag.Diagnostics_Name = new SelectList(db.Diagnostics, "ID", "Name");
            ViewBag.District_Name = new SelectList(db.District, "ID", "District1");
            ViewBag.Doctor_Name = new SelectList(db.Doctor, "ID", "Doctor1");
            ViewBag.Patient_ID = new SelectList(db.Patient, "CR_Number", "First_Name");
            ViewBag.Place = new SelectList(db.Place, "ID", "Place1");
            ViewBag.Problem_Name = new SelectList(db.Problems, "ID", "Name");
            return View();
        }

        // POST: Patient_Case/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Case_No,Patient_ID,Gender,Mobile,Medical_Records,Exam_Category,Examination_def,Allergy_Name,Allergy_Status,Allergy_Duration,Allergy_Severity,Allergy_Def,Problem_Name,Problem_Defination,Diagnostics_Name,District_Name,Place,Center_Name,Doctor_Name")] Patient_Case patient_Case)
        {
            if (ModelState.IsValid)
            {
                db.Patient_Case.Add(patient_Case);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Allergy_Name = new SelectList(db.Allergy, "ID", "Name", patient_Case.Allergy_Name);
            ViewBag.Center_Name = new SelectList(db.Center, "ID", "Center1", patient_Case.Center_Name);
            ViewBag.Diagnostics_Name = new SelectList(db.Diagnostics, "ID", "Name", patient_Case.Diagnostics_Name);
            ViewBag.District_Name = new SelectList(db.District, "ID", "District1", patient_Case.District_Name);
            ViewBag.Doctor_Name = new SelectList(db.Doctor, "ID", "Doctor1", patient_Case.Doctor_Name);
            ViewBag.Patient_ID = new SelectList(db.Patient, "CR_Number", "First_Name", patient_Case.Patient_ID);
            ViewBag.Place = new SelectList(db.Place, "ID", "Place1", patient_Case.Place);
            ViewBag.Problem_Name = new SelectList(db.Problems, "ID", "Name", patient_Case.Problem_Name);
            return View(patient_Case);
        }

        // GET: Patient_Case/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient_Case patient_Case = db.Patient_Case.Find(id);
            if (patient_Case == null)
            {
                return HttpNotFound();
            }
            ViewBag.Allergy_Name = new SelectList(db.Allergy, "ID", "Name", patient_Case.Allergy_Name);
            ViewBag.Center_Name = new SelectList(db.Center, "ID", "Center1", patient_Case.Center_Name);
            ViewBag.Diagnostics_Name = new SelectList(db.Diagnostics, "ID", "Name", patient_Case.Diagnostics_Name);
            ViewBag.District_Name = new SelectList(db.District, "ID", "District1", patient_Case.District_Name);
            ViewBag.Doctor_Name = new SelectList(db.Doctor, "ID", "Doctor1", patient_Case.Doctor_Name);
            ViewBag.Patient_ID = new SelectList(db.Patient, "CR_Number", "First_Name", patient_Case.Patient_ID);
            ViewBag.Place = new SelectList(db.Place, "ID", "Place1", patient_Case.Place);
            ViewBag.Problem_Name = new SelectList(db.Problems, "ID", "Name", patient_Case.Problem_Name);
            return View(patient_Case);
        }

        // POST: Patient_Case/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Case_No,Patient_ID,Gender,Mobile,Medical_Records,Exam_Category,Examination_def,Allergy_Name,Allergy_Status,Allergy_Duration,Allergy_Severity,Allergy_Def,Problem_Name,Problem_Defination,Diagnostics_Name,District_Name,Place,Center_Name,Doctor_Name")] Patient_Case patient_Case)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patient_Case).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Allergy_Name = new SelectList(db.Allergy, "ID", "Name", patient_Case.Allergy_Name);
            ViewBag.Center_Name = new SelectList(db.Center, "ID", "Center1", patient_Case.Center_Name);
            ViewBag.Diagnostics_Name = new SelectList(db.Diagnostics, "ID", "Name", patient_Case.Diagnostics_Name);
            ViewBag.District_Name = new SelectList(db.District, "ID", "District1", patient_Case.District_Name);
            ViewBag.Doctor_Name = new SelectList(db.Doctor, "ID", "Doctor1", patient_Case.Doctor_Name);
            ViewBag.Patient_ID = new SelectList(db.Patient, "CR_Number", "First_Name", patient_Case.Patient_ID);
            ViewBag.Place = new SelectList(db.Place, "ID", "Place1", patient_Case.Place);
            ViewBag.Problem_Name = new SelectList(db.Problems, "ID", "Name", patient_Case.Problem_Name);
            return View(patient_Case);
        }

        // GET: Patient_Case/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient_Case patient_Case = db.Patient_Case.Find(id);
            if (patient_Case == null)
            {
                return HttpNotFound();
            }
            return View(patient_Case);
        }

        // POST: Patient_Case/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Patient_Case patient_Case = db.Patient_Case.Find(id);
            db.Patient_Case.Remove(patient_Case);
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
