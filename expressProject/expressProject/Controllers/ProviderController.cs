using expressProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;

namespace expressProject.Controllers
{
    public class ProviderController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }   

        public ActionResult CustomerTable()
        {
            List<Firms> firms = importFirms();
            return View(firms);
        }
        public List<Firms> importFirms()
        {
            string jsonFirmalarPath = Server.MapPath("~/App_Data/firms.json");
            string firmsText = System.IO.File.ReadAllText(jsonFirmalarPath);

            List<Firms> firms = JsonConvert.DeserializeObject<List<Firms>>(firmsText);

            return firms;

        }
        public List<Calisanlar> importCalisanlar()
        {
            string jsonCustomerPath = Server.MapPath("~/App_Data/customer.json");
            string customerText = System.IO.File.ReadAllText(jsonCustomerPath);

            List<Calisanlar> customers = JsonConvert.DeserializeObject<List<Calisanlar>>(customerText);

            return customers;

        }

        public ActionResult Calisanlar()
        {
            List<Calisanlar> customers = importCalisanlar();
            return View(customers);
        }
        public ActionResult DeleteCustomer(string id)
        {
            List<Calisanlar> d = importCalisanlar();

            Calisanlar calisanlar = d.FirstOrDefault(c => c.ID == id);

            if (calisanlar != null)
            {
                d.Remove(calisanlar);
                string jsonData = JsonConvert.SerializeObject(d);
                string jsonFilePath = Server.MapPath("~/App_Data/customer.json");
                System.IO.File.WriteAllText(jsonFilePath, jsonData);

                TempData["SuccessMessage"] = "Çalışan silme işlemi başarıyla tamamlandı.";
            }
            else
            {
                TempData["ErrorMessage"] = "Silinecek veri bulunamadı.";
            }

            return RedirectToAction("Calisanlar");
        }

        public ActionResult Mailler()
        {
            return View();
        }
        public ActionResult YeniEposta()
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
        
        public ActionResult Calendar()
        {
            return View();
        }

        public ActionResult Users()
        {
            return View();
        }

        public ActionResult Settings()
        {
            return View();
        }

        public ActionResult RoleList()
        {
            return View();
        }

        public ActionResult ViewRoles()
        {
            return View();
        }

        public ActionResult PermList() 
        {
            return View();
        }
    }
}