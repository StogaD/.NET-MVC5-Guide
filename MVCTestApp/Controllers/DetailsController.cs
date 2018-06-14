using MVCTestApp.Infrastructure.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestApp.Controllers
{
    public class DetailsController : Controller
    {
        public DetailsController()
        {
            //total cusrtomActionInvoker - see Homecontroller
            // this.ActionInvoker = new CustomActionInvoker();
            //Modified Web.MVc ActionInvoker
            this.ActionInvoker = new CustomActionInvokerMvcBased();

        }
        // GET: Homes
        [ActionName("Index-Off")]

        public void Index()
        {
            HttpContext.Response.Write("Main Details Controller /index");
        }

        public void Help()
        {
            HttpContext.Response.Write("Main Home Controller/Help");
        }

        [NonAction]
        public void About()
        {
            HttpContext.Response.Write("About");
        }

        public void Result()
        {
            HttpContext.Response.Write("Result");
        }
    }
}