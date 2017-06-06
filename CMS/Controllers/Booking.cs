using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Dapper;

namespace CMS.Controllers
{
    public class Booking : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }
    }
}
