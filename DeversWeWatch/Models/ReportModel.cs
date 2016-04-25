using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DeversWeWatch.Models
{
    public class ReportModel
    {

        public enum Kategorier { Vandalism, AvvikandeBeteende, Bråk, Roadkill, Annat}

        public int Id { get; set; }

        [StringLength(50)]
        public string Förnamn { get; set; }
        [StringLength(50)]
        public string Efternamn { get; set; }

        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage ="Måste vara en korrekt mail"), StringLength(75)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Telefonnummer { get; set; }

        [RegularExpression(@"[0-9{6}]-[0-9]{4}", ErrorMessage = "Måste vara korrekt inskrivet [XXXXXX-XXXX]")]
        [StringLength(10, MinimumLength = 10)]
        public string Personnummer { get; set; }

        [Required]
        public DateTime Datum { get; set; }

        [Required, StringLength(50)]
        public string Plats_Adress { get; set; }

        [Required]
        public Kategorier Kategori { get; set; }

        [Required, StringLength(128)]
        public string Meddelande { get; set; }
    }
}