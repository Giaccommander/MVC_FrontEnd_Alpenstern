using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alpenstern_FrontEnd.Models
{
    public class rueckrufVM
    {
        public int id { get; set; }

        public string name { get; set; }

        public int telefon { get; set; }

        public string grund { get; set; }

        public DateTime datum_erhalten { get; set; }

        
    }
}