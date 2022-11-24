using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Net.Mime.MediaTypeNames;
using System.Web.UI.WebControls;
using System.Security.Cryptography.X509Certificates;

namespace HOL_D2_.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Index(string id)
        {
            if (id == null)
            {
                return Content("<h1>This is a demo of contentresult</h1> ");
            }
            else if (id.ToLower() == "plain")
            {
                return Content("<h1>This is a result of contentresult</h1>", "text/plain");
            }
            else if (id.ToLower() == "html")
            {
                return Content("<h1>This is the demo of contentresult</h1>", "text/html");
            }
            else if (id.ToLower() == "xml")
            {
                return Content("<h1>This the demo of contentresult</h1>", "text/xml");
            }
            return Content("Invalid content type");
        }
            public ActionResult DownloadFile()
            {
                if (!System.IO.File.Exists(@"e:\lighthouse.jpg"))
                {
                    return Content("File to be downloaded not found");
                }
                return File(@"e:\lighthouse.jpg", "image/jpg",
               "default.jpg");
            }
        public ActionResult Google()
        {
            return Redirect("http://www.google.com");
        }
        public ActionResult StartPage()
        {
            return RedirectToAction("Index", new { id = "html" });
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View("Display");
        }

    }   }
        
    

