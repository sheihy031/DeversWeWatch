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
       [HttpPost]
       public ActionResult Index(ReportModel modelInput)
        {
            var report = new ReportModel()
            {
                Datum = modelInput.Datum,
                Efternamn = modelInput.Efternamn,
                Email = modelInput.Email,
                Förnamn = modelInput.Förnamn,
                Kategori = modelInput.Kategori,
                Meddelande = modelInput.Meddelande,
                Personnummer = modelInput.Personnummer,
                Plats_Adress = modelInput.Plats_Adress,
                Telefonnummer = modelInput.Telefonnummer
            };
            
            context.Report.Add(report);
            context.SaveChanges();
            return View();
        }
    }
}