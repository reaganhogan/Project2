using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//So I made the mistakes of change the name of the folder from Authentication2 to MissionSite. I changed it back and it work.
//Note - I ran this from the gitrepo/Project2/Authentication2 folder on your desktop.

namespace Authentication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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
            ViewBag.Message = "";

            return View();
        }

    }
}