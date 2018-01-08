using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TauraForexWebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }
        
        public ActionResult Contact()
        {     
            return View();            
        }

        public ActionResult Courses()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.Message = "Thank you for Contacting us....";
            //try
            //{
            //    ViewData["FullName"] = collection[1];
            //    ViewData["Email"] = collection[2];
            //    ViewData["ContactNumber"] = collection[3];
            //    return View("FeedContactView");
            //}
            //catch
            //{
            //    return View();
            //}
            return View();

        }
    }
}