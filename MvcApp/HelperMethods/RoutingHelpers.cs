using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MvcGuides.HelperMethods
{
    public static class RoutingHelpers
    {
        public static T GetRouteVariable<T>(RouteData routeData,  string name)
        {
            object result;

            routeData.Values.TryGetValue(name, out result);
            return (T) result;
        }
    }
}