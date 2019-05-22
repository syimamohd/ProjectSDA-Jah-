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
    public class CheckUpsController : Controller
    {
        private PatientCarePlanContext db = new PatientCarePlanContext();

        // GET: CheckUps
        public ActionResult Index()
        {
            return View(db.CheckUps.ToList());
        }

        // GET: CheckUps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CheckUp checkUp = db.CheckUps.Find(id);
            if (checkUp == null)
            {
                return HttpNotFound();
            }
            return View(checkUp);
        }

        // GET: CheckUps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CheckUps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,BloodPressure,BodyTemperature,HeartRate,RespiratoryRate,TypeOfPrescription,Disease")] CheckUp checkUp)
        {
            if (ModelState.IsValid)
            {
                db.CheckUps.Add(checkUp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(checkUp);
        }

        // GET: CheckUps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CheckUp checkUp = db.CheckUps.Find(id);
            if (checkUp == null)
            {
                return HttpNotFound();
            }
            return View(checkUp);
        }

        // POST: CheckUps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,BloodPressure,BodyTemperature,HeartRate,RespiratoryRate,TypeOfPrescription,Disease")] CheckUp checkUp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(checkUp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(checkUp);
        }

        // GET: CheckUps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CheckUp checkUp = db.CheckUps.Find(id);
            if (checkUp == null)
            {
                return HttpNotFound();
            }
            return View(checkUp);
        }

        // POST: CheckUps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CheckUp checkUp = db.CheckUps.Find(id);
            db.CheckUps.Remove(checkUp);
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
