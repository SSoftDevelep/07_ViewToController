using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _07_ViewToController.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult HomePage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult HomePage(string text1,bool check1,string list1)
        {
            var t1 = Request.Form["text1"];
            var l1 = Request.Form["list1"];
            var c1=  Request.Form.GetValues("check1")[0];  // isaretliyse true,false degilse false,true alir. 0. item ilk secilen oluyor.

            return View();
        }
    }
}