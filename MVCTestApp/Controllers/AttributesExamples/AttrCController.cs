using MVCTestApp.HelperMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestApp.Controllers.AttributesExamples
{
    public class AttrCController : Controller
    {
        // GET: AttrC
        public ActionResult Index()
        {
            return View();
        }
        [ActionName("detale")]
        public void Details()
        {
            this.Send("Details action method was called via [detale] in URL - ActionName attribute was used");

        }
        [Authorize(Users = "admin")]
        public void Info()
        {
            if (Request.IsAuthenticated)
            { HttpContext.Response.Write("WithoutFilter Authenticated"); }
            else
            {
                HttpContext.Response.Write("WithoutFilter Not Authenticated");
            }
        }

        [OutputCache(Duration = 60)]
        public void WithGeneralFilter()
        {
            if (Request.IsAuthenticated)
            { HttpContext.Response.Write("WithoutFilter Authenticated"); }
            else
            {
                HttpContext.Response.Write("WithoutFilter Not Authenticated");
            }
        }
    }
}