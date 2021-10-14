using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplications.Models;

namespace WebApplications.Controllers
{
    public class Test1Controller : Controller
    {
        // GET: Test1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TriangleArea()
        {
            Test1 model = new Test1();
            return View(model);
        }
        public ActionResult Calculate(Test1 model)
        {
            try
            {
                float simpleInteresrt = (float)(0.5f * model.base1 * model.height);
                StringBuilder sbInterest = new StringBuilder();
                sbInterest.Append("<b>base1 :</b> " + model.base1 + "<br/>");
                sbInterest.Append("<b>height :</b> " + model.height + "<br/>");
                sbInterest.Append("<b>Numder Digit :</b> " + simpleInteresrt);
                return Content(sbInterest.ToString());
            }
            catch
            {
                return View("Error");
            }
        }
        public ActionResult clear()
        {
            return View();
        }
        public ActionResult TestAPI()
        {
            return View();
        }
        public ActionResult CitizenID()
        {
            Test3 model = new Test3();
            return View(model);
        }
        public ActionResult Calculate3(Test3 model)
        {
            try
            {
                StringBuilder sbInterest = new StringBuilder();
                int sum = 0;
                if (model.citizen_id.Length == 13)
                {
                    for (int i = 0; i < model.citizen_id.Length - 1; i++)
                    {
                        int n = Int32.Parse(model.citizen_id[i].ToString());
                        sum = sum + ((13 - i) * n);
                    }
                    int mod11 = sum % 11;
                    int subtract11 = 11 - mod11;
                    int simpleInteresrt1 = subtract11;
                    sbInterest.Append("<b>citizen_id :</b> " + model.citizen_id + " <br/>");
                    sbInterest.Append("<b>success :</b> " + "true" + "<br/>");
                    sbInterest.Append("<b>error_code :</b> " + "200" + " <br/>");
                    sbInterest.Append("<b>error_msg :</b> " + "" + " <br/>");
                    sbInterest.Append("<b>Number Digit :</b> " + simpleInteresrt1);
                }
                if (model.citizen_id.Length != 13)
                {
                    sbInterest.Append("<b>citizen_id :</b> " + model.citizen_id + " <br/>");
                    sbInterest.Append("<b>success :</b> " + "fales" + "<br/>");
                    sbInterest.Append("<b>error_code :</b> " + "001" + " <br/>");
                    sbInterest.Append("<b>error_msg :</b> " + "citizen_id invalid" + " <br/>");
                    string simpleInteresrt = null;
                    sbInterest.Append("<b>Number Digit :</b> " + simpleInteresrt);
                }
                return Content(sbInterest.ToString());
            }
            catch
            {
                return View("ErrorID");
            }
        }
    }
}
