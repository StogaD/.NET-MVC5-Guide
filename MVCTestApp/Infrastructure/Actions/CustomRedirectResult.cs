using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestApp.Infrastructure.Actions
{
    public class CustomRedirectResult : ActionResult
    {
        public override void ExecuteResult(ControllerContext context)
        {
            // create own response
            context.HttpContext.Response.Redirect("http://www.google.com");
        }
    }
}