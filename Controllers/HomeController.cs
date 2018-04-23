using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV_Mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PersonalInformation()
        {
            return View();
        }

        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Skills()
        {
            return View();
        }
        public ActionResult Experience()
        {
            return View();
        }
    }
}