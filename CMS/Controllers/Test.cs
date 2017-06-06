using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS.Controllers
{
    public class Test : Controller
    {
        public ActionResult Index()
        {
            var a = 1;
            var b = a + 1;
            var c = 2;
            return View ();
        }
    }
}
