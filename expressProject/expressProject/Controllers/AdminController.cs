using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace expressProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProviderTable()
        {
            return View();
        }

        public ActionResult MusteriTable()
        {
            return View();
        }

        public ActionResult EmployeeTable()
        {
            return View();
        }
    }
}