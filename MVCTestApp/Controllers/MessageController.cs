using MVCTestApp.Infrastructure.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestApp.Controllers
{
    public class MessageController : Controller
    {
        public MessageController()
        {
            //total cusrtomActionInvoker
            this.ActionInvoker = new CustomActionInvoker();
            //Modified Web.MVc ActionInvoker -see DetailsController
            //this.ActionInvoker = new CustomActionInvokerBasedOnDefault();

        }
        // GET: Homes
        [ActionName("Index-Off")]

        public void Index()
        {
            HttpContext.Response.Write("Main Message Controller /index");
        }

        public void Help()
        {
            HttpContext.Response.Write("Main Message Controller/Help");
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