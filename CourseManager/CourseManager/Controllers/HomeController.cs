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
        public ActionResult Index()
        {
            ViewBag.Message = "修改此模板以快速启动你的 ASP.NET MVC 应用程序。";

            var site = new WebsiteInfo("1212", "54565");
            return View(site);

        }

        public ActionResult About()
        {
            ViewBag.Message = "你的应用程序说明页。";

            return View();
        }
        [ChildActionOnly]

        public ActionResult Nabar()
        {
            var site = new WebsiteInfo("课程管理体系","主页");
            ViewBag.Site = site;
            return PartialView("/view/Shar/Navbar.cshtml", site);
        }
    }
}
