using expressProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace expressProject.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public List<ProviderAuthentication> importProviders()
        {
            string jsonProviderrPath = Server.MapPath("~/App_Data/providers.json");
            string providerText = System.IO.File.ReadAllText(jsonProviderrPath);

            List<ProviderAuthentication> providers = JsonConvert.DeserializeObject<List<ProviderAuthentication>>(providerText);

            return providers;
        }

        public List<ProviderAuthentication> importAdmins()
        {
            string jsonAdminPath = Server.MapPath("~/App_Data/admins.json");
            string adminText = System.IO.File.ReadAllText(jsonAdminPath);

            List<ProviderAuthentication> admins = JsonConvert.DeserializeObject<List<ProviderAuthentication>>(adminText);

            return admins;
        }
        public List<ProviderAuthentication> importCustomer()
        {
            string jsonCustomerPath = Server.MapPath("~/App_Data/customer.json");
            string customerText = System.IO.File.ReadAllText(jsonCustomerPath);

            List<ProviderAuthentication> customers = JsonConvert.DeserializeObject<List<ProviderAuthentication>>(customerText);

            return customers;
        }


        [HttpPost]
        public ActionResult Login(ProviderAuthentication model)
        {
            List<ProviderAuthentication> providers = importProviders();
            List<ProviderAuthentication> admins = importAdmins();
            List<ProviderAuthentication> customers = importCustomer();

            ProviderAuthentication authenticatedProvider = providers.FirstOrDefault(u => u.userName == model.userName && u.password == model.password);
            ProviderAuthentication authenticatedAdmin = admins.FirstOrDefault(u => u.userName == model.userName && u.password == model.password);
            ProviderAuthentication authenticatedCustomer = customers.FirstOrDefault(u => u.userName == model.userName && u.password == model.password);



            if (authenticatedProvider != null)
            {
                return RedirectToAction("Index", "Provider");
            }
            else if (authenticatedAdmin != null)
            {
                return RedirectToAction("Index", "Admin");
            }
            else if (authenticatedCustomer != null)
            {
                return RedirectToAction("Index", "Customer");
            }
            else
            {
                TempData["Hata"] = "Hatalı kullanıcı adı veya şifre girdiniz.";

                return RedirectToAction("Index", "Login");

            }
        }
    }
}