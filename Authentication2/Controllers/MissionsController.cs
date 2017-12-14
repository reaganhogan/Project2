using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Authentication2.Controllers
{
    public class MissionsController : Controller
    {
        // GET: Missions
        public ActionResult Index()
        {
            return View();
        }
       // GET: Missions
       //passes parameters to the MissionInfo view when it gets directed towards
       // public ActionResult MissionInfo(int MissionID)
       // {
       //     if (MissionID = "1")
       //     {
       //         ViewBag.MissionName = db.Database.SqlQuery<Missions>("SELECT MissionName"
       //                                                             + "FROM Missions"
       //                                                             + "WHERE MissionID = '1'");
       //         ViewBag.PresidentName = PresidentName;
       //         ViewBag.Address = Address;
       //         ViewBag.Climate = Climate;
       //         ViewBag.Religion = Religion;
       //         ViewBag.Picture = Picture;
       //         ViewBag.Language = Language;
       //         return View();

       //     }
       //     else if (MissionID = "2")
       //     {
       //         ViewBag.MissionName = MissionName;
       //         ViewBag.PresidentName = PresidentName;
       //         ViewBag.Address = Address;
       //         ViewBag.Climate = Climate;
       //         ViewBag.Religion = Religion;
       //         ViewBag.Picture = Picture;
       //         ViewBag.Language = Language;
       //         return View();
       //     }
       //     else (MissionID = "3")
       //     {
       //         ViewBag.MissionName = MissionName;
       //         ViewBag.PresidentName = PresidentName;
       //         ViewBag.Address = Address;
       //         ViewBag.Climate = Climate;
       //         ViewBag.Religion = Religion;
       //         ViewBag.Picture = Picture;
       //         ViewBag.Language = Language;
       //         return View();
       //     }
       // }
        //need to authroize and sign in to view this page
        [Authorize]
        public ActionResult FAQS()
        {
            return View();
        }
        //action method that clears the text box in the forms on the MissionInfo view
        [HttpPost]
        public ActionResult FAQAnswers(FormCollection form)
        {
            // String reply = form["New Reply"].ToString();
            // form.Clear();
            return View();
        }
    }
}