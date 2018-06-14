using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestApp.Controllers.RoutingExamples
{
    public class RouteAController : Controller
    {
        // GET: RouteA
        public ActionResult Index()
        {
            return View((object)"Index()");
        }


        [HttpPost]
        public ActionResult Index(int id)
        {
            return View((object)"Index(id)");
        }

        // GET: RouteA
        public ActionResult Info(string personID)
        {
            return View((object)"Info(personID)");
        }

        // GET: RouteA
        public ActionResult Details(string personID = "021")
        {
            return View((object)"Details(personID = 021");
        }
    }
}