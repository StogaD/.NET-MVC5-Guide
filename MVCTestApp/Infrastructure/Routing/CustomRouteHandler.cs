using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCTestApp.Infrastructure.Routing
{
    public class CustomRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {

            if ( requestContext.HttpContext.Request.RawUrl.Contains("customH"))
            {
                return new CustomHttpHandler();
            }
           
            return new MvcHttpHandler();
        }
    }
}