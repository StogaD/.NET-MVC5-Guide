using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTestApp.Infrastructure.Routing
{
    public class CustomHttpHandler : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("CustomRouteHandler");
        }
    }
}