using MVCTestApp.Infrastructure.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestApp.Controllers
{
    public class HomeController : Controller
    {

        
        public CustomRedirectResult Index()
        {
            //HttpContext.Response.Write("Main Home Controller /index");
            return new CustomRedirectResult();

        }
    }
}