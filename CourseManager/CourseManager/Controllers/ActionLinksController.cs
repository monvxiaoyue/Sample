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
    public class ActionLinksController : Controller
    {
        private CourseManageEntities db = new CourseManageEntities();

        //
        // GET: /ActionLinks/

        public ActionResult Index()
        {
            return View(db.ActionLinks.ToList());
        }

        //
        // GET: /ActionLinks/Details/5

        public ActionResult Details(int id = 0)
        {
            ActionLinks actionlinks = db.ActionLinks.Find(id);
            if (actionlinks == null)
            {
                return HttpNotFound();
            }
            return View(actionlinks);
        }

        //
        // GET: /ActionLinks/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ActionLinks/Create

        [HttpPost]
        public ActionResult Create(ActionLinks actionlinks)
        {
            if (ModelState.IsValid)
            {
                db.ActionLinks.Add(actionlinks);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(actionlinks);
        }

        //
        // GET: /ActionLinks/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ActionLinks actionlinks = db.ActionLinks.Find(id);
            if (actionlinks == null)
            {
                return HttpNotFound();
            }
            return View(actionlinks);
        }

        //
        // POST: /ActionLinks/Edit/5

        [HttpPost]
        public ActionResult Edit(ActionLinks actionlinks)
        {
            if (ModelState.IsValid)
            {
                db.Entry(actionlinks).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actionlinks);
        }

        //
        // GET: /ActionLinks/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ActionLinks actionlinks = db.ActionLinks.Find(id);
            if (actionlinks == null)
            {
                return HttpNotFound();
            }
            return View(actionlinks);
        }

        //
        // POST: /ActionLinks/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ActionLinks actionlinks = db.ActionLinks.Find(id);
            db.ActionLinks.Remove(actionlinks);
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