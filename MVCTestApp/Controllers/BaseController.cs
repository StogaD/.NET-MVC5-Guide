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
            var secretMessage = string.Empty;
            //  Take values directly or use own helper method
            var controllerFromUrl = requestContext.RouteData.Values["controller"];
            var actionrFromUrl = requestContext.RouteData.Values["action"];

            var controller = RoutingHelpers.GetRouteVariable<string>(requestContext.RouteData, "Controller");
            var action = RoutingHelpers.GetRouteVariable<string>(requestContext.RouteData, "Action");

            var responseMessage = String.Format(" Controller receives the request from URL:  {0}/{1}", controller, action);

            if (action.ToLower().Contains("secret"))
            {
                secretMessage += "This messsage is shown due to the SECRET word in the Acrion\n";
            }

           

            // Response can be prepared and sent here without calling any Views



            if (action.ToLower().Contains("exit"))
            {
                requestContext.HttpContext.Response.Redirect("~/Home");
            }
            requestContext.HttpContext.Response.Write(responseMessage);
            requestContext.HttpContext.Response.Write(secretMessage);





        }
    }
}