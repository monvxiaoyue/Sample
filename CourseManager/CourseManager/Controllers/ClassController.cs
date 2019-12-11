using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseManager.Models;

namespace CourseManager.Controllers
{
    public class ClassController : Controller
    {
        private CourseManageEntities db = new CourseManageEntities();

        //
        // GET: /Class/

        public ActionResult Index()
        {
            return View(db.Classes.ToList());
        }

        //
        // GET: /Class/Details/5

        public ActionResult Details(int id = 0)
        {
            Classes classes = db.Classes.Find(id);
            if (classes == null)
            {
                return HttpNotFound();
            }
            return View(classes);
        }

        //
        // GET: /Class/Create

        public ActionResult Create()
        {
           var teachers= db.Teachers.ToList();
           ViewBag.Teachers = teachers;
            return View();
        }

        //
        // POST: /Class/Create

        [HttpPost]
        public ActionResult Create(Classes classes)
        {
            if (ModelState.IsValid)
            {
                db.Classes.Add(classes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(classes);
        }

        //
        // GET: /Class/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Classes classes = db.Classes.Find(id);
            if (classes == null)
            {
                return HttpNotFound();
            }
            {
                var teachers = db.Teachers.ToList();
                ViewBag.Teachers = teachers;
            }
            return View(classes);
        }

        //
        // POST: /Class/Edit/5

        [HttpPost]
        public ActionResult Edit(Classes classes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(classes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(classes);
        }

        //
        // GET: /Class/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Classes classes = db.Classes.Find(id);
            if (classes == null)
            {
                return HttpNotFound();
            }
            return View(classes);
        }

        //
        // POST: /Class/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Classes classes = db.Classes.Find(id);
            db.Classes.Remove(classes);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}