﻿using DeversWeWatch.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeversWeWatch.Controllers
{
    public class HomeController : Controller
    {
        ReportContext context = new ReportContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Form(ReportModel modelInput)
        {
            if (ModelState.IsValid)
            {
                //string hämtaAnnanKategori;
                //if (modelInput.Kategori.ToString() == "Annat")
                //{
                //     hämtaAnnanKategori = Request.Form["annanKategori"];
                //}
                //else
                //{
                //    hämtaAnnanKategori = modelInput.Kategori.ToString();
                //}                
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
            }
            return View();
        }
    }
}