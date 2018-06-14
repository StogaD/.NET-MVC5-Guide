using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestApp.Controllers.RoutingExamples
{
    public class RouteBController : Controller
    {
        // GET: RouteB
        public ActionResult Index()
        {
            return View();
        }
    }
}