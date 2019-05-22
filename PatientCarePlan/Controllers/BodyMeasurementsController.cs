using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PatientCarePlan.Models;

namespace PatientCarePlan.Controllers
{
    [Authorize(Roles = "Doctor")]
    public class BodyMeasurementsController : Controller
    {
        private PatientCarePlanContext db = new PatientCarePlanContext();

        // GET: BodyMeasurements
        public ActionResult Index()
        {
            return View(db.BodyMeasurements.ToList());
        }

        // GET: BodyMeasurements/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BodyMeasurement bodyMeasurement = db.BodyMeasurements.Find(id);
            if (bodyMeasurement == null)
            {
                return HttpNotFound();
            }
            return View(bodyMeasurement);
        }

        // GET: BodyMeasurements/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BodyMeasurements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Height,Weight,BodyFatPercent,BodyMassIndex,LeanBodyMass,WaistCircumference")] BodyMeasurement bodyMeasurement)
        {
            if (ModelState.IsValid)
            {
                db.BodyMeasurements.Add(bodyMeasurement);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bodyMeasurement);
        }

        // GET: BodyMeasurements/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BodyMeasurement bodyMeasurement = db.BodyMeasurements.Find(id);
            if (bodyMeasurement == null)
            {
                return HttpNotFound();
            }
            return View(bodyMeasurement);
        }

        // POST: BodyMeasurements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Height,Weight,BodyFatPercent,BodyMassIndex,LeanBodyMass,WaistCircumference")] BodyMeasurement bodyMeasurement)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bodyMeasurement).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bodyMeasurement);
        }

        // GET: BodyMeasurements/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BodyMeasurement bodyMeasurement = db.BodyMeasurements.Find(id);
            if (bodyMeasurement == null)
            {
                return HttpNotFound();
            }
            return View(bodyMeasurement);
        }

        // POST: BodyMeasurements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BodyMeasurement bodyMeasurement = db.BodyMeasurements.Find(id);
            db.BodyMeasurements.Remove(bodyMeasurement);
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
