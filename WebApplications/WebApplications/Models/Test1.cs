using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplications.Models
{
    public class Test1
    {
        [DisplayName("ฐาน")]
        public Nullable<float> base1 { get; set; }
        [DisplayName("สูง")]
        public Nullable<float> height { get; set; }
    }
}