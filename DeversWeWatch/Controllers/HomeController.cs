using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeversWeWatch.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ReportContext context = new ReportContext();
            context.Database.Initialize(true);
            return View();
        }
    }
}