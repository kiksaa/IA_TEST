using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplications.Models
{
    public class Test3
    {
        /*public int id { get; set; }*/
        [DisplayName("หมายเลขบัตรประชาชน")]
        public string citizen_id { get; set; }
        /*[DisplayName("success")]
        public string success { get; set; }
        [DisplayName("error_code")]
        public string error_code { get; set; }
        [DisplayName("error_msg")]
        public string error_msg { get; set; }*/
    }
}