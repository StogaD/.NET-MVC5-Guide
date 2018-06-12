
using AirPlane.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirPlane.WebUI.Controllers.MVCGuide
{
    public class MvcGuideController : Controller {

        public string EFAction()
        {
           
            //GIT tets 13:155


            string retunString = "";

            var stx = new EFStudentRepository();
         
            var sts = stx.Students.Where(x => x.Address != null);
            foreach (var s in sts)
            {
                retunString += s.StudentName + " ";


                // return View(repo.Students);
            }     return retunString;
        }
        public ActionResult ControllerAction()
        {
            return View();
        }
        public ActionResult ViewAction()
        {
            return View();
        }
        // GET: MvcGuide
        public ActionResult HelperMethod()
        {
            
            return View();
        }
    }
}