using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestApp.Controllers.AttributesExamples
{
    public class AttrAController : Controller
    {
        private List<string> mockData;
        public AttrAController()
        {
            mockData = new List<string>{
                "House",
                "Pension",
                "Health",
                "Moto",
            };

        }
        // GET: AttrA
        public ActionResult Index()
        {
            return View();
        }

        [RangeException]
        public void GetData(int index)
        {
            // test with throw exception here  or simulate some invalid case
            // throw new ArgumentOutOfRangeException();

            var result = mockData[index];

            HttpContext.Response.Write(result);
        }

    }
}