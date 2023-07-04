using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace expressProject.Models
{
    public class Firms
    {
        public int ID { get; set; }
        public string name { get; set; }
    }

    public class Calisanlar
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public int provider_ID { get; set; }

    }
}