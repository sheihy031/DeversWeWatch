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

        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage ="Måste vara en korrekt mail")]
        public string Email { get; set; }

        public string Telefonnummer { get; set; }
        
        public string Personnummer { get; set; }

        [Required]
        public DateTime Datum { get; set; }

        [Required]
        public string Plats_Adress { get; set; }

        [Required]
        public Kategorier Kategori { get; set; }

        [Required]
        public string Meddelande { get; set; }
    }
}