using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VIPRPrototype.Models;

namespace VIPRPrototype.Controllers
{
    public class PatientController : Controller
    {
        DataContext db = new DataContext();
        //
        // GET: /Patient/

        public ActionResult Index()
        {
            return View(db.Patients);
        }

        //
        // GET: /Patient/Details/5

        public ActionResult Details(int id)
        {
            return View(db.Patients.Find(id));
        }

        //
        // GET: /Patient/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Patient/Create

        [HttpPost]
        public ActionResult Create(Patient patient)
        {
            try
            {
                db.Patients.Add(patient);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Patient/Edit/5

        public ActionResult Edit(int id)
        {
            return View(db.Patients.Find(id));
        }

        //
        // POST: /Patient/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Patient patient)
        {
            try
            {
                db.Entry(patient).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                throw;
                return View();
            }
        }

        //
        // GET: /Patient/Delete/5

        public ActionResult Delete(int id)
        {
            return View(db.Patients.Find(id));
        }

        //
        // POST: /Patient/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Patient patient)
        {
            try
            {
                db.Entry(patient).State = EntityState.Deleted;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
