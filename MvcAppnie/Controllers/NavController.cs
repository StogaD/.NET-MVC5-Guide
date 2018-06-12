using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcGuide.Controllers
{
    public class NavController : Controller
    {
        // GET: Nav
        public PartialViewResult Menu()
        {
            return PartialView();
        }
    }
}