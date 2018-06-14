using MVCTestApp.Infrastructure.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestApp.Controllers.AttributesExamples
{
    public class AttrBController : Controller
    {

        public AttrBController()
        {
      
        }
        // GET: AttrB
        public ActionResult Index()
        {
            return View();
        }

        // GET: AttrB
        [CustomAuth(true)]
        public void GetSecret()
        {
            HttpContext.Response.Write("Please have a look on secret data - *[only for local requests ]");

        }
    }
}