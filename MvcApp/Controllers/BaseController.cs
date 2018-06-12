using MvcGuides.HelperMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcGuides.Controllers
{
    public class BaseController : IController
    {
        public void Execute(RequestContext requestContext)
        {

            var controller = RoutingHelpers.GetRouteVariable<string>(requestContext.RouteData, "Controller");
            var action = RoutingHelpers.GetRouteVariable<string>(requestContext.RouteData, "Action");

            var responseMessage = String.Format(" Controller receives the request from URL:  {0}/{1}", controller, action);

            // Response can be prepared and sent here without calling any Views
            requestContext.HttpContext.Response.Write(responseMessage);
        }
    }
}