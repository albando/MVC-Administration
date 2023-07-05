using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace expressProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult YeniEposta()
        {
            return View();
        }

        public ActionResult Mailler()
        {
            return View();
        }
        public ActionResult Calendar()
        {
            return View();
        }
        public ActionResult GoruntuleYanitla()
        {
            return View();
        }
        public ActionResult GenelBakis()
        {
            return View();
        }
        public ActionResult EditProfile()
        {
            return View();
        }
        public ActionResult Settings()
        {
            return View();
        }
    }
}