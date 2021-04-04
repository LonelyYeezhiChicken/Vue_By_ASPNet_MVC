using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VueByAspNet_Mvc.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// toDoList
        /// </summary>
        /// <returns></returns>
        public ActionResult toDoList()
        {
            return View();
        }
        
    }
}