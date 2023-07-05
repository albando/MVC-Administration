using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace expressProject.Models
{
    public class ProviderAuthentication
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public int firmID { get; set; }
    }

    public class AdminAuthentication
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}