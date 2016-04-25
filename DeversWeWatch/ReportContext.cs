using DeversWeWatch.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DeversWeWatch
{
    public class ReportContext :DbContext
    {
        public ReportContext() : base("ReportDb")
        {}
       public DbSet<ReportModel> Report { get; set; }
    }
}