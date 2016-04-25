using DeversWeWatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeversWeWatch.Controllers
{
    
    public class FormController : Controller
    {
        ReportContext context = new ReportContext();
        public ActionResult Index ()
        {
            return View();
        }
      
    }
}