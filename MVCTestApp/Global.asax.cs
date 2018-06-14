using AirPlane.WebUI.Infrastructure;
using MVCTestApp.Infrastructure.Controllers;
using MVCTestApp.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVCTestApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        /* Config section */
        FeatureSwicth controllerFactoryFlag = FeatureSwicth.Disabled;


        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            if (controllerFactoryFlag == FeatureSwicth.Enabled)
            {
                /* Create Controller instance by using custom ControllerFactory 1-total custom  2 - based on Default */
            ControllerBuilder.Current.SetControllerFactory(new BasedOnDefaultControllerFactory(new CustomControllerActivator()));
            ControllerBuilder.Current.SetControllerFactory(new CustomControllerFactory());
            }






        }
    }
}
