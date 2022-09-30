using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSWMS_TEST
{
    public class ServiceModels
    {
        public class User
        {
            public int userid { get; set; }
            public string namalengkap { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string status { get; set; }

        }
    }
}