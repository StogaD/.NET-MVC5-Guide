using MVCTestApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestApp.Controllers
{
    public class CustomerController : Controller
    {

        private const int DefaultID = 50;
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public void Info(int customerID)
        {
        
            //generate a fully qualified url.
            var url = Url.Action("Info", "Customer", new { customerID = 10 });

            HttpContext.Response.Write(customerID);

        }
        public void GetData(int customerID = DefaultID)
        {
            HttpContext.Response.Write(customerID);
        }

        [HttpPost]
        public ActionResult SaveData(CustomerModelView customer)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string id)
        {
            return View(id);
        }

        public ActionResult Present(int ID, int password)
        {
            return View();
        }
    }
}