using CourseManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseManager.Controllers
{
    public class HomeController : Controller
    {
        private CourseManageEntities db = new CourseManageEntities();

        public ActionResult Index()
        {
            var sidebars= db.SideBars.ToList();
            ViewBag.SideBars = sidebars;
            return View(new WebsiteInfo("班级管理","主页"));

        }

        public ActionResult About()
        {
            ViewBag.Message = "你的应用程序说明页。";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "you contact page";
            return View();
        }
        [ChildActionOnly]
        public ActionResult Navbar()
        {
            var site = new WebsiteInfo("课程管理体系","主页");
            ViewBag.Site = site;
            return PartialView("~/Views/Shared/Navbar.cshtml");
        }

        [ChildActionOnly]
        public ActionResult SideBar()
        {
            var sidebars = db.SideBars.ToList();
            ViewBag.SideBars = sidebars;
            return PartialView("~/Views/Shared/SideBar.cshtml");
        }


    }
}
