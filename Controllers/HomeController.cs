using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CachingMvcDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Duration = 10,VaryByParam = "None")]
        public ActionResult ShowData()
        {
            ViewBag.TimeofCache = DateTime.Now.ToLongTimeString();
            return View();
        }
        
        [HttpPost]
        public ActionResult ShowData(int id)
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}