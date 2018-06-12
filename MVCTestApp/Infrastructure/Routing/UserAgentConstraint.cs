using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MVCTestApp.Infrastructure.Routing
{
    public class UserAgentConstraint : IRouteConstraint
    {
        private string userAgent;
        public UserAgentConstraint(string requestedUserAgnet)
        {
            this.userAgent = requestedUserAgnet;
        }

        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return httpContext.Request.UserAgent != null && httpContext.Request.UserAgent.Contains(userAgent);
        }
     
    }
}