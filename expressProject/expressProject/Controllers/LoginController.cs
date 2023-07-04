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

        public List<AuthenticationProfile> importProviders()
        {
            string jsonProviderrPath = Server.MapPath("~/App_Data/providers.json");
            string providerText = System.IO.File.ReadAllText(jsonProviderrPath);

            List<AuthenticationProfile> providers = JsonConvert.DeserializeObject<List<AuthenticationProfile>>(providerText);

            return providers;
        }

        public List<AuthenticationProfile> importAdmins()
        {
            string jsonAdminPath = Server.MapPath("~/App_Data/admins.json");
            string adminText = System.IO.File.ReadAllText(jsonAdminPath);

            List<AuthenticationProfile> admins = JsonConvert.DeserializeObject<List<AuthenticationProfile>>(adminText);

            return admins;
        }
        public List<AuthenticationProfile> importCustomer()
        {
            string jsonCustomerPath = Server.MapPath("~/App_Data/customer.json");
            string customerText = System.IO.File.ReadAllText(jsonCustomerPath);

            List<AuthenticationProfile> customers = JsonConvert.DeserializeObject<List<AuthenticationProfile>>(customerText);

            return customers;
        }


        [HttpPost]
        public ActionResult Login(AuthenticationProfile model)
        {
            List<AuthenticationProfile> providers = importProviders();
            List<AuthenticationProfile> admins = importAdmins();
            List<AuthenticationProfile> customers = importCustomer();

            AuthenticationProfile authenticatedProvider = providers.FirstOrDefault(u => u.userName == model.userName && u.password == model.password);
            AuthenticationProfile authenticatedAdmin = admins.FirstOrDefault(u => u.userName == model.userName && u.password == model.password);
            AuthenticationProfile authenticatedCustomer = customers.FirstOrDefault(u => u.userName == model.userName && u.password == model.password);



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