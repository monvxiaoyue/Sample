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
    public class SideBarsController : Controller
    {
        private CourseManageEntities db = new CourseManageEntities();

        //
        // GET: /SideBars/

        public ActionResult Index()
        {
            return View(db.SideBars.ToList());
        }

        //
        // GET: /SideBars/Details/5

        public ActionResult Details(int id = 0)
        {
            SideBars sidebars = db.SideBars.Find(id);
            if (sidebars == null)
            {
                return HttpNotFound();
            }
            return View(sidebars);
        }

        //
        // GET: /SideBars/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /SideBars/Create

        [HttpPost]
        public ActionResult Create(SideBars sidebars)
        {
            if (ModelState.IsValid)
            {
                db.SideBars.Add(sidebars);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sidebars);
        }

        //
        // GET: /SideBars/Edit/5

        public ActionResult Edit(int id = 0)
        {
            SideBars sidebars = db.SideBars.Find(id);
            if (sidebars == null)
            {
                return HttpNotFound();
            }
            return View(sidebars);
        }

        //
        // POST: /SideBars/Edit/5

        [HttpPost]
        public ActionResult Edit(SideBars sidebars)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sidebars).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sidebars);
        }

        //
        // GET: /SideBars/Delete/5

        public ActionResult Delete(int id = 0)
        {
            SideBars sidebars = db.SideBars.Find(id);
            if (sidebars == null)
            {
                return HttpNotFound();
            }
            return View(sidebars);
        }

        //
        // POST: /SideBars/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            SideBars sidebars = db.SideBars.Find(id);
            db.SideBars.Remove(sidebars);
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