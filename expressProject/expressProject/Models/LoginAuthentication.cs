using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace expressProject.Models
{
    public class AuthenticationProfile
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
    class ProviderAuthentication : AuthenticationProfile
    {
        public int firmID { get; set; }
    }

    class AdminAuthentication : AuthenticationProfile{
    }
}