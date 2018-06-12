﻿using MVCTestApp.Infrastructure.Enums;
using MVCTestApp.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCTestApp.Infrastructure.Routing
{
    public  static class CustomRoutesRegister
    {
        public  static void RegisterCustomRoutes(RouteCollection routes, RoutingSwicth routeSwitch)
        {
           if(routes == null || routeSwitch == RoutingSwicth.Disabled)
            {
                throw new NullReferenceException("routeCollection shouldn't be null - pass a valid collecton");
            }


            // 1. Creating a simple Route, MvcRouteHandler from System.Web.Mvc
            var newRoute = new Route("{controller }/Route{action}", new MvcRouteHandler());
            routes.Add(newRoute);

            //   2. Ignore all specific URL
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //   3. Ignore some Static content
            routes.IgnoreRoute("Content/{filename}.html");

            //   4. Use constrains - Chrome only
            routes.MapRoute(
               name: "ForChromeOnly",
               url: "ALL",
               defaults: new { controller = "Custom", action = "Index", id = UrlParameter.Optional },
               constraints: new { customConstraint = new UserAgentConstraint("Chrome") }
               );

            //   5. Use constrains - IE only
            routes.MapRoute(
               name: "Spec_Static_SegmIE",
               url: "ALL",
               defaults: new { controller = "Custom", action = "CustomVariable", id = UrlParameter.Optional },
               constraints: new { customConstraint = new UserAgentConstraint("Trident") });

            //   6. static Page
            routes.MapRoute(
                name: "showImage",
                url: "Content/StaticContent.html",
                defaults: new { controller = "Custom", action = "showImage", id = UrlParameter.Optional }
                );


            //  7. static URL Segment  372
            routes.MapRoute(
                name: "Add_Segment",
                url: "Secret/{controller}/{action}/{id}",
                defaults: new { controller = "Admin", action = "Index", id = UrlParameter.Optional }
             );

            /* 8. static URL Prefix Segment  372*/
            routes.MapRoute(
                name: "CustomDS",
                url: "DS{controller}/{action}/{id}",
                defaults: new { controller = "RouteCustom", action = "Index", id = 1 }
         );
            /* 9. constraints for url value*/
            routes.MapRoute(
               name: "Paging",
               url: "P{page}",
               defaults: new { controller = "AirCraft", action = "List", category = (string)null },
               constraints: new { page = @"\d+" }
               );

            /* 10. constraints for action part*/
            routes.MapRoute(
                "CateforyAndPage",
                "{category}/P{page}",
                new { controller = "AirCraft", action = "List" },
                new { page = @"\d+" }
            );

            /* 11. static URL Segment  as prefix in Action part 372*/
            routes.MapRoute(
                name: "Segment2",
                url: "{controller}/X{action}/{id}",
                defaults: new { controller = "AirCraft", action = "List", id = UrlParameter.Optional }
            );
            /*  12.  Defining http constraint and namespace  */
            var myMpaRoute = routes.MapRoute(
                name: "DefaultWithconstraint",
                url: "{controller}/{action}/{id}/{*catchall}",
                defaults: new { controller = "AirCraft", action = "List", id = UrlParameter.Optional },
                constraints: new { action = "^L.*", httpMethod = new HttpMethodConstraint("GET", "POST") },
                namespaces: new[] { "AirPlane.WebUI.Controllers.RoutingURL" }
            );

            /*  13.  Defining  namespace  */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}/{*catchall}",
                defaults: new { controller = "AirCraft", action = "List", id = UrlParameter.Optional },
                namespaces: new[] { "AirPlane.WebUI.Controllers" }
                
                );

/* TODO:             "investiage this part" */
                /*disable searching other namespaces  
                 myMpaRoute.DataTokens["UseNamespaceFallback"] = false ; */


            /* 14. Most general routing */
            routes.MapRoute(
                name: "AllCategorty",
                url: "",
                defaults: new { controller = "AirCraft", action = "List", category = (string)null, page = 1 }
                );

            routes.MapRoute(
               name: "Paging",
               url: "P{page}",
               defaults: new { controller = "AirCraft", action = "List", category = (string)null },
               constraints: new { page = @"\d+" }   //one on ore integers {page}
               );
            //P1
            //P2

            routes.MapRoute(name: "CategoryOnly",
                url: "{category}",
                defaults: new { controller = "AirCraft", action = "List", page = 1 }
                );
            //Test
            //Military

            routes.MapRoute("CateforyAndPage",
            "{category}/P{page}",
            new { controller = "AirCraft", action = "List" },
            new { page = @"\d+" }
            );

            //Military/P2

            routes.MapRoute(
                name: "FormRoute",
                url: "People/{action}",
                defaults: new { controller = "People", action = "Indenx" },
                namespaces: new[] { "AirPlane.WebUI.Controllers.MVCGuide" }
                );

            //People/Indenx
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "AirCraft", action = "List", id = UrlParameter.Optional },
                namespaces: new[] { "AirPlane.WebUI.Controllers" }
            //AirCraft/List/4
            );

          /* 15. To enable attribute routing, call MapMvcAttributeRoutes during configuration. */
          routes.MapMvcAttributeRoutes();
        }



    }
}
 