using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleRestSand.Models
{
    public class Person
    {
        public int ID{ get; set; }
        public string Nome{ get; set; }
        public string  Cognome{ get; set; }
        public long Affitto { get; set; }
        public DateTime StardtDate{ get; set; }
        public DateTime EndDate { get; set; }

    }
}