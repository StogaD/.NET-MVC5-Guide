using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestApp.Controllers.AttributesExamples
{
    public class RangeExceptionAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled && filterContext.Exception is ArgumentOutOfRangeException)
            {
                // Redirect to static page
                filterContext.Result = new RedirectResult("~/Content/Errors/RangeErrorPage.html");

                // or create own response

                filterContext.HttpContext.Response.Write("ERROR");

                // set to true to inform the exception is handled
                filterContext.ExceptionHandled = true;
            }
        }
    }
}